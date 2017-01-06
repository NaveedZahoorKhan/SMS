using System.Data.Entity;
using SMS.DAL.Interfaces;

namespace SMS.DAL
{
    public abstract class SmsContext : DbContext, IContext
    {
        protected SmsContext() : base("name=SmsEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



        
    }
}