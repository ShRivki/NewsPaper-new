using ManagingANewspaper;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IDesignerService
    {
        public Task<IEnumerable<Designer>> GetAllAsync();


        public Task<Designer> GetByIdAsync(int id);


        public Task<Designer> PostDesignerAsync(Designer value);


        public Task<Designer> PutDesignerAsync(int id, Designer value);


        public Task<Designer> DeleteDesignerAsync(int id);

    }
}
