namespace ApiSample.Services.Dto
{
    public class NotificationResponseDto
    {
        public bool Status { get; set; }
        public object? Result { get; set; }

        public NotificationResponseDto(bool status, object? result)
        {
            Status = status;
            Result = result;
        }
    }
}
