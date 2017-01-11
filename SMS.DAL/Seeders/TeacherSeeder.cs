using System.Collections.Generic;
using System.Linq;
using SMS.Common.Enums;
using SMS.Model.Models;

namespace SMS.DAL.Seeders
{
    public struct TeacherSeeder
    {
        public static List<int> InitalTeacherIds => new List<int> { 1, 2, 3, 4,5,6,7,8};

        public static List<Teacher> GetInitialTeacheres()
        {
            return InitalTeacherIds.Select(i => new Teacher()
            {
             SectionId   = SectionSeeder.InitalSectionIds[i-1],
             TeacherId = InitalTeacherIds[i-1],
             TeacherType = TeacherType.Permanent,
             
            }).ToList();

        }
    }
}