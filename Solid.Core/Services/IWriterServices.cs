using ManagingANewspaper;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IWriterService
    {
      

        public Task<IEnumerable<Writer>> GetAllAsync();


        public Task<Writer> GetByIdAsync(int id);


        public Task<Writer> PostWriterAsync(Writer value);


        public Task<Writer> PutWriterAsync(int id, Writer value);


        public Task<Writer> DeleteWriterAsync(int id);


    }
}
