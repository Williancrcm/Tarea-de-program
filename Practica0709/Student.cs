using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0709
{
    class Student
    {
        public int IDstudent { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student {IDstudent = 0293,  firstname = "Carlos", lastname = "Rosales", age = 20, gender = "male" },
                new Student {IDstudent = 9493, firstname = "Jose", lastname = "Flores", age = 29, gender = "male"},
                new Student {IDstudent = 9843, firstname = "Karla", lastname = "Romero", age = 39, gender = "female"},
                new Student {IDstudent = 8923, firstname = "Rocio", lastname = "Guevara", age = 33, gender = "female"},
                new Student {IDstudent = 3948, firstname = "Kevin", lastname = "Lopez", age = 19, gender = "male"},
                new Student {IDstudent = 9843, firstname = "Isabel", lastname = "Pineda", age = 22, gender = "female"},
            };

            return students; 
        }
    }
}
