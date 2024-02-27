using ManagingANewspaper;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IArticleRepository
    {
        public Task<IEnumerable<Article>> GetAsync();

        public  Task<Article> GetAsync(int id);

        public Task<Article> PostAsync(Article value);

        public Task<Article> PutAsync(int id, Article value);

        public  Task<Article> DeleteAsync(int id);
    }
}
