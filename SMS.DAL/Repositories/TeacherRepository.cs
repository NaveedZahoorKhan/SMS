
using SMS.DAL.Helpers;
using SMS.DAL.Interfaces;
using SMS.Model.Models;

namespace SMS.DAL.Repositories
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}