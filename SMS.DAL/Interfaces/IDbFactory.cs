using System;
using VMS.DAL;

namespace SMS.DAL.Interfaces
{
    public interface IDbFactory: IDisposable
    {
        SmsContext Init();
    }
}
