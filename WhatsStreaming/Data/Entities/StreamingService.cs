namespace WhatsStreaming.Data.Entities
{
    public class StreamingService
    {
        public int StreamingServiceId { get; set; }
        public string StreamingServiceName { get; set; }
        public string Website { get; set; }

        public ICollection<ShowStreaming> Shows { get; set; }
        public ICollection<MovieStreaming> Movies { get; set; }
    }
}
