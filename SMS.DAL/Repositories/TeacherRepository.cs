using SMS.DAL.Interfaces;
using SMS.DAL.Repositories;

namespace SMS.DAL.Repositories
{
    public class TeacherRepository : EntityFrameworkRepository<TeacherRepository, SmsContext>, ITeacherRepository
    {
        public TeacherRepository(IUnitOfWork uow) : base(uow)
        {
        }
        
    }
}