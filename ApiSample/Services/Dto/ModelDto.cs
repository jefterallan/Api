namespace ApiSample.Services.Dto
{
    public class ModelDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool Active { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
