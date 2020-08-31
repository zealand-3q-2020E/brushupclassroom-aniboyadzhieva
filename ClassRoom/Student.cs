using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public string Name { get; }
        public int BirthMonth { get; }
        public int Birthday { get; }

        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            {
                return "Winter";
            }
            else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring";
            }
            else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }
            else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
                return "Autmn";
            }
            return "Something is wrong";
        }

        public override string ToString()
        {
            return $"Student name: {Name} , birth month: {BirthMonth}, date of birth: {Birthday}";
        }
    }
    }

