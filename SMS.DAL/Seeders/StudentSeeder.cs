using System.Collections.Generic;
using System.Linq;
using SMS.Model.Models;

namespace SMS.DAL.Seeders
{
    public struct StudentSeeder
    {
        public static List<int> InitalStudentIds => new List<int> { 1, 2, 3, 4,5,6,7,8};

        public static List<Student> GetInitialStudents()
        {
            return InitalStudentIds.Select(i => new Student()
            {
             StudentId   = UserSeeder.InitialUserIds [i-1],
             SectionId = SectionSeeder.InitalSectionIds[i-1],
             
            }).ToList();

        }
    }
}