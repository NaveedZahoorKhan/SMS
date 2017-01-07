using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class StudentRepository : EntityFrameworkRepository<IStudentRepository, SmsContext>
    {
        public StudentRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}