using System;

namespace SMS.DAL.Interfaces
{
    public interface IContext : IDisposable
    {
        int SaveChanges();
    }
}
