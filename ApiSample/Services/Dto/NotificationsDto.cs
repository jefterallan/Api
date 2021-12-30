namespace ApiSample.Services.Dto
{
    public class NotificationsDto
    {
        public string Message { get; set; }

        public NotificationsDto(string message)
        {
            Message = message;
        }
    }
}
