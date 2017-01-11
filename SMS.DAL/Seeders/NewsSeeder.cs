using System.Collections.Generic;
using System.Linq;
using SMS.Model.Models;

namespace SMS.DAL.Seeders
{
    public struct NewsSeeder
    {
        public static List<int> InitalNewsIds => new List<int> { 1, 2, 3, 4,5,6,7,8};

        public static List<News> GetInitialClasses()
        {
            return InitalNewsIds.Select(i => new News()
            {
                Id = InitalNewsIds[i-1],
                Code = "xxxxxx",
                IsActive = true,
                Title = "xxxxxx",
                Description = "xxxxxx",
                UserId = UserSeeder.InitialUserIds[i-1],
            }).ToList();

        }
    }
}