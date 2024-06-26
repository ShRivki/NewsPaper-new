﻿using AutoMapper;
using ManagingANewspaper.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Editors")]
    [ApiController]
    [Authorize]
    public class EditorController : ControllerBase
    {
        // GET: api/<Customer>
        private readonly IEditorService _editorService;
        private readonly IMapper _mapper;
        public EditorController(IEditorService es, IMapper mapper)
        {
            _editorService = es;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Editor>>> GetAsync()
        {
            var list= await _editorService.GetAllAsync();
            var list1=list.Select(e=>_mapper.Map<EditorDto>(e));
            return Ok(list1);
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var res = await _editorService.GetByIdAsync(id);
            var resDto=_mapper.Map<EditorDto>(res);
            return res!=null?Ok(resDto):NotFound(resDto);
        }

        // POST api/<Customer>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EditorPostModel value)
        {
            var editor = _mapper.Map<Editor>(value);
            var res=await _editorService.PostEditorAsync(editor);
            var resDto = _mapper.Map<EditorDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EditorPostModel value)
        {
            var editor = _mapper.Map<Editor>(value);
            var res =await _editorService.PutEditorAsync(id, editor);
            var resDto = _mapper.Map<EditorDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);

        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _editorService.DeleteEditorAsync(id);
            var resDto = _mapper.Map<EditorDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }
    }
}
