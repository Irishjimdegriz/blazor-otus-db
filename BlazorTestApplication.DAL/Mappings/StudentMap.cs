using BlazorTestApplication.Data.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTestApplication.Data.Mappings
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Id(x => x.Student_Id).GeneratedBy.SequenceIdentity("STUDENT_ID_SEQ");
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.MiddleName);
            Table("Student");

            HasManyToMany(x => x.CoursesEnrolledIn)
            .Cascade.All()
            .Inverse()
            .Table("StudentCourse");
        }
    }
}
