using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace ApiSample.Configuration
{
    public class ApiExplorerGroupPerVersionConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerNamespace = controller.ControllerType.Namespace;
            var apiVersion = controllerNamespace?.Split('.').Last().ToLower() ?? string.Empty;

            controller.ApiExplorer.GroupName = apiVersion;
        }
    }
}
