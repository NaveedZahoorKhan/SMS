
using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class TeacherRepository : EntityFrameworkRepository<ITeacherRepository, SmsContext>
    {
        public TeacherRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}