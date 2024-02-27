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

        public Writer Writer { get; set; }

        public List<Designer> Designers { get; set; }
    }
}
