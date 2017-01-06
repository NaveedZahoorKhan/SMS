using System.Data.Entity;

namespace SMS.DAL
{
    public class SmsContext : DbContext
    {
        protected SmsContext() : base()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}