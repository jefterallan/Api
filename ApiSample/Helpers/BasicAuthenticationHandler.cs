using ApiSample.Data.Models;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace ApiSample.Helpers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private const string MISSINGHEADER = "Missing Authorization Header";
        private const string INVALIDAUTHORIZATION = "Invalid Authorization Header";
        private const string INVALIDCREDENTIAL = "Invalid Username or Password";
        private const string KEY = "Authorization";

        private readonly IUsersService UserService;
        
        public BasicAuthenticationHandler(
            IUsersService userService,
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
            UserService = userService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var endpoint = Context.GetEndpoint();

            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
                return AuthenticateResult.NoResult();

            if (!Request.Headers.ContainsKey(KEY))
            {
                Logger.LogError(MISSINGHEADER);
                return AuthenticateResult.Fail(MISSINGHEADER);
            }
            
            UsersDto? user;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers[KEY]);
                var credentialsBytes = Convert.FromBase64String(authHeader.Parameter ?? string.Empty);
                var credentials = Encoding.UTF8.GetString(credentialsBytes).Split(new[] { ':' }, 2);
                var username = credentials.FirstOrDefault() ?? string.Empty;
                var password = credentials.LastOrDefault() ?? string.Empty;

                var credential = new CredentialDto(username, password);
                user = await UserService.FindApiCredentials(credential);
            }
            catch (Exception)
            {
                Logger.LogError(INVALIDAUTHORIZATION);
                return AuthenticateResult.Fail(INVALIDAUTHORIZATION);
            }

            if (user == null)
            {
                Logger.LogError(INVALIDCREDENTIAL);
                return AuthenticateResult.Fail(INVALIDCREDENTIAL);
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, user.Group.Name)
            };

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
