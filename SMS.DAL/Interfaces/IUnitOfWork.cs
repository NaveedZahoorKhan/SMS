
namespace SMS.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        IStudentRepository StudentRepository { get; }
        IClassRepository ClassRepository{ get; }
        ISectionRepository SectionRepository { get; }
        INewsRepository NewsRepository { get; }
        IAnnouncementRepository AnnouncementRepository { get; }
        ITimeTableRepository TimeTableRepository { get; }
        /*IRepository<T> Repository<T>() where T : class;*/
        void Commit();
    }
}
