using WhatsStreaming.Data.Entities;

namespace WhatsStreaming.Data.Database
{
    public class SeedDatabase
    {
        private readonly WhatsStreamingContext _context;

        public SeedDatabase(WhatsStreamingContext context)
        {
            _context = context;
        }

        public void AddSeedData()
        {
            List<StreamingService> streamingServices = new List<StreamingService>()
                {
                    new StreamingService()
                    {
                        StreamingServiceName = "Hulu",
                        Website = "www.hulu.com/"
                    },

                    new StreamingService()
                    {
                        StreamingServiceName = "Prime",
                        Website = "www.amazon.com/amazonprime"
                    },

                    new StreamingService()
                    {
                        StreamingServiceName = "Netflix",
                        Website = "www.netflix.com"
                    }
                };

            _context.StreamingServices.AddRange(streamingServices);
            _context.SaveChanges();
        }
    }
}
