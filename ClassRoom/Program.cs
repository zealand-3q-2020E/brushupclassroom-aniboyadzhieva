using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {

        static void Main(string[] args)
        {
            ClassRoom room1 = new ClassRoom
            {
                ClassName = "Design"
            };
           

            room1.ClassList.Add(new Student("Elvis", 12,22));
            room1.ClassList.Add(new Student("Josh", 10, 12));
            room1.ClassList.Add(new Student("Alex", 04, 10));

            

            foreach (var student in room1.ClassList)
            {
                Console.WriteLine(student);
                Console.WriteLine(student.Season());
            }

            Console.ReadKey();
        }
    }
}
