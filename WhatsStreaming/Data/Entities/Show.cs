namespace WhatsStreaming.Data.Entities
{
    public class Show
    {
        public int ShowId { get; set; }
        public string Title { get; set; }

        public int TotalSeasons { get; set; }

        public ICollection<ShowStreaming> AvailableOn { get; set; }
    }
}
