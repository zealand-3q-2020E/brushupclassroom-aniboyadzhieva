using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        

        public Student(string name, int birthMonth, int birthday)
        {
            name = Name;
            birthMonth = BirthMonth;
            birthday = Birthday;
        }

        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int Birthday { get; set; }

    }
    }

