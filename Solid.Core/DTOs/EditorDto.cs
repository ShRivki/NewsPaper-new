using ManagingANewspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class EditorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public TypeEditor TEditor { get; set; }
        public float Salary { get; set; } = 0;
        public int Priority { get; set; }
    }
}
