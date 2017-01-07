using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class TimeTableRepository : EntityFrameworkRepository<ITimeTableRepository, SmsContext>
    {
        public TimeTableRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}