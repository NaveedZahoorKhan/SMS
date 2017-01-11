using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using SMS.DAL.Configurations;
using SMS.DAL.Interfaces;
using SMS.DAL.Mapping;
using SMS.Model.Models;

namespace SMS.DAL
{
    public class SmsContext : DbContext
    {
        public SmsContext() : base("name=SmsEntites")
        {
        }

        public SmsContext(string connectionString): base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new AnnouncementConfiguration());
            modelBuilder.Configurations.Add(new ClassConfiguration());
            modelBuilder.Configurations.Add(new TimeTableConfiguration());
            modelBuilder.Configurations.Add(new NewsConfiguration());
            modelBuilder.Configurations.Add(new SectionConfiguration());
        }

        #region DbSet

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<TimeTable> TimeTables { get; set; }
        public virtual DbSet<News> Newses  { get; set; }
        public virtual DbSet<Section> Sections  { get; set; }

        #endregion
        public virtual void Commit()
        {
            try
            {
                ManageStamps();

                base.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {
                //                var newException = new FormattedDbEntityValidationException(e);
                StringBuilder sb = new StringBuilder();

                foreach (var failure in e.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), e
                ); // Add the original exception as the innerException
            }
        }

        private void ManageStamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is ModelBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            /*var currentUsername = HttpContext.Current != null && HttpContext.Current.User != null
                ? HttpContext.Current.User.Identity.Name
                : "Anonymous";

            var currentUserId = HttpContext.Current != null && HttpContext.Current.User != null
                ? HttpContext.Current.User.Identity.GetUserId()
                : null;*/

            /*var currentUserId;
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((ModelBase)entity.Entity).CreationDate = DateTime.Now;
                    if (currentUserId != null)
                        ((ModelBase)entity.Entity).CreatedBy = Convert.ToInt32(currentUserId);
                }
                else
                {
                    ((ModelBase)entity.Entity).ModificationDate = DateTime.Now;
                    if (currentUserId != null)
                        ((ModelBase)entity.Entity).ModifiedBy = Convert.ToInt32(currentUserId);
                }
            }*/
        }

    }

}