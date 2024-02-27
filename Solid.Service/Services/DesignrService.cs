using ManagingANewspaper;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Service.Services
{
    public class DesignrService : IDesignerService
    {
        private readonly IDesignerRepository _designerRepository;
        public DesignrService(IDesignerRepository dd)
        {
            _designerRepository = dd;
        }

        public async Task<IEnumerable<Designer>> GetAllAsync() {
            return await _designerRepository.GetAsync();           
        }

        public async Task<Designer> GetByIdAsync(int id)
        { 
           return await _designerRepository.GetAsync(id);
        }

        public async Task<Designer> PostDesignerAsync(Designer value)
        {
            return await _designerRepository.PostAsync(value);
        }

        public async Task<Designer> PutDesignerAsync(int id, Designer value)
        {
            return await _designerRepository.PutAsync(id, value);
        }

        public async Task<Designer> DeleteDesignerAsync(int id) 
        {
            return await _designerRepository.DeleteAsync(id);
        }
    }
}
