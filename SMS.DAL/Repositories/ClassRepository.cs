using SMS.DAL.Helpers;
using SMS.DAL.Interfaces;
using SMS.Model.Models;

namespace SMS.DAL.Repositories
{
    public class ClassRepository : RepositoryBase<Class>, IClassRepository 
    {
        public ClassRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}