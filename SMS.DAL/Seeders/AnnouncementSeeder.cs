﻿using System.Collections.Generic;
using System.Linq;
using SMS.Model.Models;

namespace SMS.DAL.Seeders
{
    public struct AnnouncementSeeder
    {
        public static List<int> InitalAnnouncementIds => new List<int> { 1, 2, 3, 4,5,6,7,8};

        public static List<Announcement> GetInitialAnnouncements()
        {
            return InitalAnnouncementIds.Select(i => new Announcement()
            {
                Id = InitalAnnouncementIds[i-1],
                Code = "xxxxxx",
                IsActive = true,
                Title = "xxxxxx",
                Description = "xxxxxx",
                UserId = UserSeeder.InitialUserIds[i-1]
            }).ToList();

        }
    }
}