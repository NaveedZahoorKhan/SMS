using SMS.DAL.Helpers;
using SMS.DAL.Interfaces;
using SMS.Model.Models;

namespace SMS.DAL.Repositories
{
    public class TimeTableRepository : RepositoryBase<TimeTable>, ITimeTableRepository
    {
        public TimeTableRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}