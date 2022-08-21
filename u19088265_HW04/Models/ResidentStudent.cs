using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19088265_HW04.Models
{
    public class ResidentStudent:Student
    {
        protected int _idNumber;
        protected string _gender;

        public ResidentStudent(int idNumber, string studentName, string studentSurname,string gender):base(studentName, studentSurname)
        {
            _idNumber = idNumber;
            _gender = gender;
        }
    }
}