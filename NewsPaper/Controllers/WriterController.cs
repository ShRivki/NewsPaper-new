using AutoMapper;
using ManagingANewspaper.models;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Writers")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;
        public WriterController(IWriterService ws,IMapper mapper)
        {
            _writerService = ws;
            _mapper = mapper;
        }
        // GET: api/<Worker>
        [HttpGet]
        public async Task<ActionResult< IEnumerable<Writer>>> GetAsync()
        {
            var list = await _writerService.GetAllAsync();
            var list1=list.Select(w=>_mapper.Map<WriterDto>(w));
            return Ok(list1);
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var res = await _writerService.GetByIdAsync(id);
            var resDto=_mapper.Map<WriterDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // POST api/<Customer>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] WriterPostModel value)
        {
            var writer=_mapper.Map<Writer>(value);
            var res =await _writerService.PostWriterAsync(writer);
            var resDto = _mapper.Map<WriterDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] WriterPostModel value)
        {
            var writer = _mapper.Map<Writer>(value);
            var res =await _writerService.PutWriterAsync(id, writer);
            var resDto = _mapper.Map<WriterDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);

        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _writerService.DeleteWriterAsync(id);
            var resDto = _mapper.Map<WriterDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }
    }
}
