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
    public class WriterService: IWriterService
    {
        private readonly IWriterRepository _writerRepository;
        public WriterService(IWriterRepository dd)
        {
            _writerRepository = dd; 
        }

        public async Task<IEnumerable<Writer>> GetAllAsync()
        {
            return await _writerRepository.GetAsync();
        }

        public async Task<Writer >GetByIdAsync(int id)
        {
            return await _writerRepository.GetAsync(id);
        }

        public async Task<Writer> PostWriterAsync(Writer value)
        {
            return await _writerRepository.PostAsync(value);
        }

        public async Task<Writer> PutWriterAsync(int id, Writer value)
        {
            return await _writerRepository.PutAsync(id, value);
        }

        public async Task<Writer> DeleteWriterAsync(int id)
        {
            return  await _writerRepository.DeleteAsync(id);
        }

       
    }
}
