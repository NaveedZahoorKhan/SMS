using System;
using System.Collections.Generic;

namespace SMS.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        IContext AssignContext<T>() where T : class, IContext;
        ICollection<IContext> Contexts { get; }
    }
}
