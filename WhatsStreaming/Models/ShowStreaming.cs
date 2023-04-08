namespace WhatsStreaming.Models
{
    public class ShowStreaming
    {
        public int ShowStreamingId { get; set; }
        public int ShowId { get; set; }
        public int StreamingServiceId { get; set; }
        public bool IsPremium { get; set; }
        public int AvailableSeasons { get; set; }
        public Show Show { get; set; }
        public StreamingService StreamingService { get; set; }
    }
}
