using ManagingANewspaper;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ArticleRepository:IArticleRepository
    {
        private readonly DataContext _context;
        public ArticleRepository(DataContext dd)
        {
            _context = dd;
        }

        public  async Task<IEnumerable<Article>> GetAsync()
        {
            return await _context.Articles.Include(w=>w.Writer).ToListAsync();
        }

        public async Task<Article> GetAsync(int id)
        {
            Article article = new Article();
            return await _context.Articles.FindAsync(id);

        }


        public async Task<Article> PostAsync(Article value)
        {
            _context.Articles.Add(value);
            await _context.SaveChangesAsync();
            return await _context.Articles.FindAsync(value.Id); 
        }


        public async Task<Article> PutAsync(int id, Article value)
        {
            Article article;
            article =await _context.Articles.FindAsync(id);
            if (article != null)
            {
                article.Subject = value.Subject;
                article.Writer = value.Writer;
                article.Department = value.Department;
                article.Designers = value.Designers;
                await _context.SaveChangesAsync();
            }
            return article;

        }


        public async Task<Article> DeleteAsync(int id)
        {
            Article article;
            article =await _context.Articles.FindAsync(id);
            if (article != null)
            {
                _context.Articles.Remove(article);
                await _context.SaveChangesAsync();
            }
            return article;
        }
       
    }
}
