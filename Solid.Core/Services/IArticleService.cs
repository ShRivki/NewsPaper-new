using ManagingANewspaper;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IArticleService
    {

        public Task<IEnumerable<Article>> GetAllAsync();


        public Task<Article> GetByIdAsync(int id);


        public Task<Article> PostArticleAsync(Article value);


        public Task<Article> PutArticleAsync(int id, Article value);


        public Task<Article> DeleteArticleAsync(int id);
    }
}
