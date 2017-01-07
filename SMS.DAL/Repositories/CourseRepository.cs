using SMS.DAL.Interfaces;

namespace SMS.DAL.Repositories
{
    public class CourseRepository : EntityFrameworkRepository<ICourseRepository, SmsContext>
    {
        public CourseRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}