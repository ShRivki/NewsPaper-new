﻿using AutoMapper;
using ManagingANewspaper.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Articles")]
    [ApiController]
    [Authorize]
    public class ArticleController : ControllerBase
    {
        // GET: api/<ValuesController>

        //  private DataContext dataDesigner;
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        public ArticleController(IArticleService ds, IMapper mapper)
        {
            _articleService = ds;
            _mapper = mapper;
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<Article>>> GetAsync()
        {
            var list = await _articleService.GetAllAsync();
            var list1 = list.Select(d => _mapper.Map<ArticleDto>(d));
            return Ok(list1);
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var res = await _articleService.GetByIdAsync(id);
            var resDto = _mapper.Map<ArticleDto>(res);
            return resDto != null ? Ok(resDto) : NotFound(resDto);
        }

        // POST api/<Customer>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ArticlePostModel value)
        {
            var article = _mapper.Map<Article>(value);
            var res = await _articleService.PostArticleAsync(article);
            var resDto = _mapper.Map<ArticleDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ArticlePostModel value)
        {
            var article = _mapper.Map<Article>(value);
            var res = await _articleService.PutArticleAsync(id, article);
            var resDto = _mapper.Map<ArticleDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _articleService.DeleteArticleAsync(id);
            var resDto = _mapper.Map<ArticleDto>(res);
            return res != null ? Ok(resDto) : NotFound(resDto);
        }
    }
}
