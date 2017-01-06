using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class AnnouncementRepository : EntityFrameworkRepository<IAnnouncementRepository, SmsContext>, IAnnouncementRepository
    {
        public AnnouncementRepository(IUnitOfWork uow) : base(uow)
        {
        }

    }
}