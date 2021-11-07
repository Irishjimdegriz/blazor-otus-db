using BlazorTestApplication.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTestApplication.Data.Models
{
    public class TeacherModel
    {
        public int Teacher_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public TeacherModel() { }

        public TeacherModel(Teacher teacher)
        {
            Teacher_Id = teacher.Teacher_Id;
            FirstName = teacher.FirstName;
            LastName = teacher.LastName;
            MiddleName = teacher.MiddleName;
            CourseId = teacher.Course.Course_Id;
            CourseName = teacher.Course.CourseName;
        }

        public Teacher ConvertToDbModel()
        {
            return new Teacher() { 
                Teacher_Id = this.Teacher_Id, 
                FirstName = this.FirstName, 
                MiddleName = this.MiddleName, 
                LastName = this.LastName
            };
        }
    }
}
