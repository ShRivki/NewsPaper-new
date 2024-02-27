using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using Solid.Core.Services;
using Solid.Core;
using AutoMapper;
using Solid.Core.DTOs;
using ManagingANewspaper.models;
using ManagingANewspaper.mappings;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Designers")]
    [ApiController]
    public class DesignerController : ControllerBase
    {
        // GET: api/<Customer>

        //  private DataContext dataDesigner;
        private readonly IDesignerService _designerService;
        private readonly IMapper _mapper;
        public DesignerController(IDesignerService ds,IMapper mapper)
        {
            _designerService = ds;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Designer>>> GetAsync()
        {
            var list= await _designerService.GetAllAsync();
            var list1=list.Select(d=>_mapper.Map<DesingerDto>(d));
            return Ok(list1);
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var res = _designerService.GetByIdAsync(id);
            var resDto = _mapper.Map<DesingerDto>(res);
            return resDto != null? Ok(resDto) : NotFound(resDto);
        }

        // POST api/<Customer>
        [HttpPost]
        public ActionResult Post([FromBody] DesignerPostModel value)
        {
            var designer = _mapper.Map<Designer>(value);
           var res= _designerService.PostDesignerAsync(designer);
            var resDto = _mapper.Map<DesingerDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DesignerPostModel value)
        {
            var designer = _mapper.Map<Designer>(value);
            var res= _designerService.PutDesignerAsync(id,designer);
            var resDto = _mapper.Map<DesingerDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var res = _designerService.DeleteDesignerAsync(id);
            var resDto = _mapper.Map<DesingerDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }
    }
}
