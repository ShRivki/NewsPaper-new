using ManagingANewspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IEditorRepository
    {
        public Task<IEnumerable<Editor>> GetAsync();

        public Task<Editor> GetAsync(int id);

        public Task<Editor> PostAsync(Editor value);

        public Task<Editor> PutAsync(int id, Editor value);

        public Task<Editor> DeleteAsync(int id);
    }
}
