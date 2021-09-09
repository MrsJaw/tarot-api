using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TarotApi.Domain.Domains;
using TarotApi.Domain.Models;
using TarotApi.ViewModels;

namespace TarotApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarotController : ControllerBase
    {
        private readonly IReadingDomain _reader;
        private readonly ILogger<TarotController> _logger;
        private readonly IMapper _mapper;

        public TarotController(ILogger<TarotController> logger, IReadingDomain reader, IMapper mapper)
        {
            _logger = logger;
            _reader = reader;
            _mapper = mapper;
        }

        [HttpGet("reading-types")]
        public IEnumerable<string> GetReadingTypes()
        {
            return Enum.GetNames(typeof(ReadingType));
        }


        [HttpGet("read/{readingType}")]
        public ActionResult<ReadingViewModel> GetReadingTypes([Required] string readingType)
        {
            ReadingType type = (ReadingType)Enum.Parse(typeof(ReadingType), readingType, true);
            var reading = _reader.DoTarotReading(type);
            if(reading is null)
            {
                return NotFound();
            }
            var result = new ReadingViewModel(){ Draws = _mapper.Map<List<DrawViewModel>>(reading) };
            return Ok(result);
        }
    }
}
