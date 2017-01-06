using System.Collections.Generic;

namespace SMS.DAL.Interfaces
{
    public interface IReadOnlyRepository<out T>
    {
        IEnumerable<T> GetAll();
    }
}
