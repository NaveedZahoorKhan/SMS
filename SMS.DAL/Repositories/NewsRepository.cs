using SMS.DAL.Helpers;
using SMS.DAL.Interfaces;
using SMS.Model.Models;

namespace SMS.DAL.Repositories
{
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        
        public NewsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}