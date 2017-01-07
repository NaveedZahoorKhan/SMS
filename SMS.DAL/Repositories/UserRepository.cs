using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class UserRepository : EntityFrameworkRepository<IUserRepository, SmsContext>
    {
        public UserRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}