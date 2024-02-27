using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IEditorService
    {
        public Task<IEnumerable<Editor>> GetAllAsync();


        public Task<Editor> GetByIdAsync(int id);


        public Task<Editor> PostEditorAsync(Editor value);


        public Task<Editor> PutEditorAsync(int id, Editor value);


        public Task<Editor> DeleteEditorAsync(int id);
    }
}
