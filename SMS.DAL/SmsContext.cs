using System.Data.Entity;
using SMS.DAL.Interfaces;

namespace SMS.DAL
{
    public class SmsContext : DbContext, IContext
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