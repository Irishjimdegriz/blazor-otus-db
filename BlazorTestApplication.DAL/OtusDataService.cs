using BlazorTestApplication.Data.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorTestApplication.DAL
{
    public class OtusDataService
    {
        public List<Course> GetCourses()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            try
            {
                return session.Query<Course>().ToList();
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        public List<Student> GetStudents()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            try
            {
                return session.Query<Student>().ToList();
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        public List<Teacher> GetTeachers()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            try
            {
                return session.Query<Teacher>().ToList();
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        public Teacher InsertTeacher(Teacher teacher, int courseId)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            using (ITransaction tx = session.BeginTransaction())
            {
                var selectedCourse = session.Query<Course>().FirstOrDefault(x => x.Course_Id == courseId);

                selectedCourse.AddTeacher(teacher);
                session.SaveOrUpdate(selectedCourse);

                tx.Commit();
            }

            return teacher;
        }
    }
}
