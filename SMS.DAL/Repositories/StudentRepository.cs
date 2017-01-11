using SMS.DAL.Helpers;
using SMS.DAL.Interfaces;
using SMS.Model.Models;

namespace SMS.DAL.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}