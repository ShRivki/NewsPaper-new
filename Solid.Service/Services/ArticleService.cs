using ManagingANewspaper;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository dd)
        {
            _articleRepository = dd;
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            return await _articleRepository.GetAsync();
        }

        public async Task<Article> GetByIdAsync(int id)
        {
            return await _articleRepository.GetAsync(id);
        }

        public async Task<Article> PostArticleAsync(Article value)
        {
            return await _articleRepository.PostAsync(value);
        }

        public async Task<Article> PutArticleAsync(int id, Article value)
        {
            return await _articleRepository.PutAsync(id, value);
        }

        public async Task<Article> DeleteArticleAsync(int id)
        {
            return await _articleRepository.DeleteAsync(id);
        }
    }

}
