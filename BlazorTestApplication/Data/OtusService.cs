using BlazorTestApplication.DAL;
using BlazorTestApplication.Data.Model;
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

        public Task<List<Teacher>> GetTeachersAsync()
        {
            var otusDataService = new OtusDataService();
            return Task.FromResult(otusDataService.GetTeachers());
        }
    }
}
