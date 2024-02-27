using ManagingANewspaper;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class EditorRepository: IEditorRepository
    {
        private readonly DataContext _context;
        public EditorRepository(DataContext dd)
        {
            _context = dd;
        }

        public async Task<IEnumerable<Editor>> GetAsync()
        {
            return await _context.Editors.ToListAsync(); 
        }

        public async Task<Editor> GetAsync(int id)
        {
            Editor editor = new Editor();
            return await _context.Editors.FindAsync(id);
          
        }


        public async Task<Editor> PostAsync(Editor value)
        {
            _context.Editors.Add(value);
            await _context.SaveChangesAsync();
            return await _context.Editors.FindAsync(value.Id);
        }


        public async Task<Editor> PutAsync(int id, Editor value)
        {
            Editor editor;
            editor = await _context.Editors.FindAsync(id);
            if (editor != null)
            {
                editor.Name = value.Name;
                editor.Phone = value.Phone;
                editor.Adress = value.Adress;
                editor.TEditor = value.TEditor;
                editor.Priority = value.Priority;
                await _context.SaveChangesAsync();
            }
            return editor;

        }


        public async Task<Editor> DeleteAsync(int id)
        {
            Editor editor;
            editor = await _context.Editors.FindAsync(id);
            if (editor != null)
            {
                _context.Editors.Remove(editor);
                await _context.SaveChangesAsync() ;
            }
            return editor;
        }
    }
}
