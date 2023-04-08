namespace WhatsStreaming.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public ICollection<MovieStreaming> AvailableOn { get; set; }
    }
}
