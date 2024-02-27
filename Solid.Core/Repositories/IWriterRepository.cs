using ManagingANewspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Core.Repositories
{
    public interface IWriterRepository
    {

        public Task<IEnumerable<Writer>> GetAsync();

        public Task<Writer> GetAsync(int id);

        public Task<Writer> PostAsync(Writer value);

        public Task<Writer> PutAsync(int id, Writer value);

        public Task<Writer> DeleteAsync(int id);
    }
}
