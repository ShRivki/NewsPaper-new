using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using Solid.Core.Services;
using Solid.Core;
using AutoMapper;
using Solid.Core.DTOs;
using ManagingANewspaper.models;
using ManagingANewspaper.mappings;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Designers")]
    [ApiController]
    [Authorize]
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
            var list1=list.Select(d=>_mapper.Map<DesignerDto>(d));
            return Ok(list1);
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var res = await _designerService.GetByIdAsync(id);
            var resDto = _mapper.Map<DesignerDto>(res);
            return resDto != null? Ok(resDto) : NotFound(resDto);
        }

        // POST api/<Customer>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DesignerPostModel value)
        {
            var designer = _mapper.Map<Designer>(value);
           var res=await _designerService.PostDesignerAsync(designer);
            var resDto = _mapper.Map<DesignerDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DesignerPostModel value)
        {
            var designer = _mapper.Map<Designer>(value);
            var res= await _designerService.PutDesignerAsync(id, designer);
            var resDto = _mapper.Map<DesignerDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var res =await _designerService.DeleteDesignerAsync(id);
            var resDto = _mapper.Map<DesignerDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }
    }
}
