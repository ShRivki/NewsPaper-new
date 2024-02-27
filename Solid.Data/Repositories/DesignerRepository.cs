using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class DesignerRepository: IDesignerRepository
    {
        private readonly DataContext _context;
        public DesignerRepository( DataContext dd)
        {
            _context = dd;  
        }

        public async Task<IEnumerable<Designer>> GetAsync()
        {
             return _context.Designers;
        }

        public async Task<Designer> GetAsync(int id)
        {
            Designer designer = new Designer();
            return await _context.Designers.FindAsync(id);
         
        }

       
        public async Task<Designer> PostAsync( Designer value)
        {
            _context.Designers.Add(value);
            await _context.SaveChangesAsync();
            return await _context.Designers.FindAsync( value.Id);
        }

     
        public async Task<Designer> PutAsync(int id, Designer value)
        {
            Designer designer;
            designer = await  _context.Designers.FindAsync(id);
            if (designer != null)
            {
                designer.Name = value.Name;
                designer.Phone = value.Phone;
                designer.Adress = value.Adress;
                designer.IsDesigningAi = value.IsDesigningAi;
                designer.Priority = value.Priority;
                designer.Articles = value.Articles;
                await _context.SaveChangesAsync();
            }
            return designer;
            
        }

       
        public async Task<Designer> DeleteAsync(int id)
        {
            Designer designer;
            designer = await _context.Designers.FindAsync(id);
            if (designer != null)
            {
                _context.Designers.Remove(designer);
                await _context.SaveChangesAsync();
            }
            return designer;
        }
    }
}
