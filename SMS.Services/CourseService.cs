using SMS.DAL.Interfaces;
using SMS.Model.Models;
using VMS.Service;

namespace SMS.Services.Interfaces
{
    public class CourseService: ServiceBase<Course>, ICourseService
    {
        public CourseService(IUnitOfWork unitOfWork, IRepository<Course> repository) : base(unitOfWork, repository)
        {
        }
    }
}