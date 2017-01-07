using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class NewsRepository : EntityFrameworkRepository<INewsRepository, SmsContext>
    {
        public NewsRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}