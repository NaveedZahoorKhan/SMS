using System;
using System.Collections.Generic;
using System.Linq;
using SMS.Model.Models;

namespace SMS.DAL.Seeders
{
    public struct CourseSeeder
    {
        public static List<int> InitalCourseIds => new List<int> { 1, 2, 3, 4,5,6,7,8};

        public static List<Course> GetInitialCourses()
        {
            return InitalCourseIds.Select(i => new Course()
            {
                Id = InitalCourseIds[i-1],
                Code = "xxxxxx",
                IsActive = true,
                Title = "xxxxxx",
                Description = "xxxxxx",
                ClassId = ClassSeeder.InitalClassIds[i-1],
                TimeSpan = TimeSpan.FromHours(1),
                
                
            }).ToList();

        }
    }
}