using SMS.DAL.Interfaces;
using SMS.Model.Models;
using VMS.Service;

namespace SMS.Services.Interfaces
{
    public class SectionService : ServiceBase<Section>, ISectionService
    {
        public SectionService(IUnitOfWork unitOfWork, IRepository<Section> repository) : base(unitOfWork, repository)
        {
        }
    }
}