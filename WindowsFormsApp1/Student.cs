using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student
    {
        public int idstudent { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string genero { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{ idstudent= 1001, firstname= "karla", lastname="claros", age=17, genero = "femenino" },
                new Student{ idstudent= 1002, firstname= "julissa", lastname="hernandez", age=18, genero = "femenino" },
                new Student{ idstudent= 1003, firstname= "carlos", lastname="rivera", age=20, genero = "masculino" },
                new Student{ idstudent= 1004, firstname= "saul", lastname="lopez", age=19, genero = "masculino"},
                new Student{ idstudent= 1005, firstname= "ismael", lastname="luna", age=18, genero = "masculino"},
                new Student{ idstudent= 1006, firstname= "alfredo", lastname="laines", age=17, genero = "masculino"},
                new Student{ idstudent= 1007, firstname= "erick", lastname="cano", age=22, genero = "masculino"}
            };

            return students;
        }


    }
}
