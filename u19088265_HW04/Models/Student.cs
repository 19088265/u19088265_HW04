using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace u19088265_HW04.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        //[Display(Name = "Name")]
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public string School { get; set; }
        public int Group { get; set; }

    }

    public class OurDatabase
    {

        List<Student> _Students;
        public List<Student> Students
        {
            get
            {
                _Students = new List<Student>();

                _Students.AddRange(new[]
                {
                    new Student{StudentId = 1, StudentName = "Fradis", StudentSurname = "Callum", Age = 12, Grade = 6, School = "Soweto Primary", Group = 2},
                    new Student{StudentId = 2, StudentName = "Noli", StudentSurname = "James", Age = 15, Grade = 10, School = "Rise Secondary", Group = 3},
                    new Student{StudentId = 3, StudentName = "Sama", StudentSurname = "Jones", Age = 17, Grade = 12, School = "Rise Secondary", Group = 3},
                    new Student{StudentId = 4, StudentName = "Noxolo", StudentSurname = "Mbele", Age = 6, Grade = 0, School = "Little Rose Creche", Group = 1},
                    new Student{StudentId = 5, StudentName = "Dimpho", StudentSurname = "Mokoena", Age = 5, Grade = 0, School = "Little Rose Creche", Group = 1},
                    new Student{StudentId = 6, StudentName = "Calvin", StudentSurname = "Arnaut", Age = 10, Grade = 4, School = "Soweto Primary", Group = 2},

                }
                );
                return _Students;
            }

            set
            {
                _Students = value;
            }
        }


    }

    
}



