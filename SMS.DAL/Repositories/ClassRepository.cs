using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class ClassRepository : EntityFrameworkRepository<IClassRepository, SmsContext> 
    {
        public ClassRepository(IUnitOfWork uow) : base(uow)
        {

        }
    }
}