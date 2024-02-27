using ManagingANewspaper;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Core.Repositories
{
    public interface IDesignerRepository
    {      
        public Task<IEnumerable<Designer>> GetAsync();

        public Task<Designer> GetAsync(int id);

        public Task<Designer> PostAsync(Designer value);

        public Task<Designer> PutAsync(int id, Designer value);

        public Task<Designer> DeleteAsync(int id);
    }
}
