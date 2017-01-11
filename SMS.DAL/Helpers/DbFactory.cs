using System;
using SMS.DAL;
using SMS.DAL.Interfaces;

namespace SMS.DAL.Helpers
{
    public class DbFactory : Disposable, IDbFactory
    {
        SmsContext _dbContext;

        public SmsContext Init() => _dbContext ?? (_dbContext = new SmsContext(GetConnection()));

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }

        private string GetConnection()

        {
            string s = $@"{Environment.MachineName}\SQLEXPRESS";
            string cnString = $"Data Source={s};Initial Catalog=VmsDevDb;Integrated Security=True;";
           
            // cn = new SqlConnection(cnString);
            return cnString;
        }
    }
}
