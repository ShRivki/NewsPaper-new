using ManagingANewspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }

        public WriterDto Writer { get; set; }

        public List<DesignerDto> Designers { get; set; }
    }
}
