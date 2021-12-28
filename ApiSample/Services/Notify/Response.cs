namespace ApiSample.Services.Notify
{
    public class Response
    {
        public bool Status { get; set; }
        public object? Result { get; set; }

        public Response(bool status, object? result)
        {
            Status = status;
            Result = result;
        }
    }
}
