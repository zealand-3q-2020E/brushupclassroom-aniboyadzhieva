using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        private string className;
        private List<Student> classList;
        private DateTime dateTimeSemesterStart;

        public ClassRoom()
        {

        }

        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime DateTimeSemesterStart { get; set; }
    }
}
