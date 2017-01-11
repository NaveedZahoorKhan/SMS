using System.Collections.Generic;
using System.Linq;
using SMS.Model.Models;

namespace SMS.DAL.Seeders
{
    public struct SectionSeeder
    {
        public static List<int> InitalSectionIds => new List<int> { 1, 2, 3, 4,5,6,7,8};

        public static List<Section> GetInitialSectiones()
        {
            return InitalSectionIds.Select(i => new Section()
            {
                Id = InitalSectionIds[i-1],
                ClassId = ClassSeeder.InitalClassIds[i-1],
                
                
            }).ToList();

        }
    }
}