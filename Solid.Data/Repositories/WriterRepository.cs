using ManagingANewspaper;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class WriterRepository: IWriterRepository
    {
        private readonly DataContext _context;
        public WriterRepository(DataContext dd)
        {
            _context = dd;
        }
        public async Task<IEnumerable<Writer>> GetAsync()
        {
            return await _context.Writers.ToListAsync();
        }


        public async Task<Writer> GetAsync(int id)
        {
           return await _context.Writers.FindAsync(id);
        }


        public async Task<Writer> PostAsync( Writer value)
        {
            _context.Writers.Add(value);
            await _context.SaveChangesAsync();
            return await _context.Writers.FindAsync(value.Id);
        }

        public async Task<Writer> PutAsync(int id,  Writer value)
        {
            Writer writer;
            writer = await _context.Writers.FindAsync(id);
            if (writer != null)
            {
                writer.Adress = value.Adress;
                writer.Name = value.Name;
                writer.Phone = value.Phone;
                writer.Salary = value.Salary;
                writer.TWriter = value.TWriter;
                writer.Priority = value.Priority;
                writer.Articles = value.Articles;
                await _context.SaveChangesAsync();
            }
            return writer;
        }


        public async Task<Writer> DeleteAsync(int id)
        {
            Writer writer;
            writer = await _context.Writers.FindAsync(id);
            if (writer != null)
            {
                _context.Writers.Remove(writer);
                await _context.SaveChangesAsync();
            }
            return writer;

        }
    }
}
