

using SMS.DAL.Interfaces;
using SMS.DAL.Repositories;

namespace SMS.DAL.Helpers
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private SmsContext _smsContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
            UserRepository = new UserRepository(dbFactory);
            StudentRepository = new StudentRepository(dbFactory);
            TeacherRepository = new TeacherRepository(dbFactory);
            UserRepository = new UserRepository(dbFactory);
            NewsRepository = new NewsRepository(dbFactory);
            TimeTableRepository= new TimeTableRepository(dbFactory);
          
        }

        public IUserRepository UserRepository { get; set; }

        public SmsContext SmsContext => _smsContext ?? (_smsContext = _dbFactory.Init());

        

        public void Commit()
        {
            SmsContext.Commit();
        }

        public void Dispose()
        {
            SmsContext.Dispose();
        }

        public ITeacherRepository TeacherRepository { get; }
        public IStudentRepository StudentRepository { get; }
        public IClassRepository ClassRepository { get; }
        public ISectionRepository SectionRepository { get; }
        public INewsRepository NewsRepository { get; }
        public IAnnouncementRepository AnnouncementRepository { get; }
        public ITimeTableRepository TimeTableRepository { get; }
        /*public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);

                var repositoryInstance = Activator.CreateInstance(repositoryType
                    .MakeGenericType(typeof(T)), RpsContext);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }*/
    }
}
