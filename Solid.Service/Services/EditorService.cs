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
    public class EditorService: IEditorService
    {
        private readonly IEditorRepository _editorRepository;
        public EditorService(IEditorRepository dd)
        {
            _editorRepository = dd;
        }

        public async Task<IEnumerable<Editor>> GetAllAsync()
        {
           return await _editorRepository.GetAsync();            
        }

        public async Task<Editor> GetByIdAsync(int id)
        {
            return await _editorRepository.GetAsync(id);
        }

        public async Task<Editor> PostEditorAsync(Editor value)
        {
            return await _editorRepository.PostAsync(value);
        }

        public async Task<Editor> PutEditorAsync(int id, Editor value)
        {
            return  await _editorRepository.PutAsync(id, value);
        }

        public async Task<Editor> DeleteEditorAsync(int id)
        {
             return await _editorRepository.DeleteAsync(id);
        }

    }
}
