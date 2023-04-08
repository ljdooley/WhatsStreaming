namespace WhatsStreaming.Models
{
    public class MovieStreaming
    {
        public int MovieStreamingId { get; set; }
        public int MovieId { get; set; }
        public int StreamingServiceId { get; set; }
        public bool IsPremium { get; set; }
        public Movie Movie { get; set; }

        public StreamingService StreamingService { get; set; }
    }
}
