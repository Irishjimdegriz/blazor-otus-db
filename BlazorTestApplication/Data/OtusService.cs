using BlazorTestApplication.DAL;
using BlazorTestApplication.Data.Model;
using BlazorTestApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTestApplication.Data
{
    public class OtusService
    {
        public Task<List<Course>> GetCoursesAsync()
        {
            var otusDataService = new OtusDataService();
            return Task.FromResult(otusDataService.GetCourses());
        }

        public Task<List<Student>> GetStudentsAsync()
        {
            var otusDataService = new OtusDataService();
            return Task.FromResult(otusDataService.GetStudents());
        }

        public Task<List<TeacherModel>> GetTeachersAsync()
        {
            var otusDataService = new OtusDataService();
            return Task.FromResult(otusDataService.GetTeachers().Select(x => new TeacherModel(x)).ToList());
        }

        public Task<TeacherModel> SaveTeacherAsync(TeacherModel teacher)
        {
            var otusDataService = new OtusDataService();
            return Task.FromResult(new TeacherModel(otusDataService.InsertTeacher(teacher.ConvertToDbModel(), teacher.CourseId)));
        }
    }
}
