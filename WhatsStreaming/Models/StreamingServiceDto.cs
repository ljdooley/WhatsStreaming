using WhatsStreaming.Data.Entities;

namespace WhatsStreaming.Models
{
    public class StreamingServiceDto
    {
        public int StreamingServiceId { get; set; }
        public string StreamingServiceName { get; set; }
        public string Website { get; set; }

        public static StreamingServiceDto CreateDtoFromEntity(StreamingService streamingService)
        {
            StreamingServiceDto dtoToReturn = new();

            dtoToReturn.StreamingServiceId = streamingService.StreamingServiceId;
            dtoToReturn.StreamingServiceName= streamingService.StreamingServiceName;
            dtoToReturn.Website= streamingService.Website;

            return dtoToReturn;
        }

        public static List<StreamingServiceDto> CreateDtoCollectionFromEntity(IEnumerable<StreamingService> streamingServices)
        {
            List<StreamingServiceDto> dtoListToReturn = new();

            foreach (var service in streamingServices)
            {
                dtoListToReturn.Add(CreateDtoFromEntity(service));
            }

            return dtoListToReturn;
        }
    }
}
