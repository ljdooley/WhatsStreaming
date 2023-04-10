using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatsStreaming.Data;
using WhatsStreaming.Data.Entities;
using WhatsStreaming.Models;

namespace WhatsStreaming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamingServicesController : ControllerBase
    {
        private readonly WhatsStreamingContext _context;

        public StreamingServicesController(WhatsStreamingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StreamingServiceDto>>> Get()
        {
            var streamingServices = await _context.StreamingServices.ToListAsync();

            return StreamingServiceDto.CreateDtoCollectionFromEntity(streamingServices);
        }
    }
}
