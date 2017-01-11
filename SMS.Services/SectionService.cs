using System.Collections.Generic;
using SMS.DAL.Interfaces;
using SMS.Model.Models;
using SMS.Services.Interfaces;
using VMS.Service;

namespace SMS.Services
{
    public class SectionService : ServiceBase<Section>, ISectionService
    {
        public SectionService(IUnitOfWork unitOfWork, IRepository<Section> repository) : base(unitOfWork, repository)
        {

        }

        public void SaveSection()
        {
            UnitOfWork.Commit();
            
        }

        public void CreateSection(Section section)
        {
            UnitOfWork.SectionRepository.Add(section);
        }

        public void UpdateSection(Section section)
        {
            UnitOfWork.SectionRepository.Update(section);
        }

        public void DeleteSection(Section section)
        {
            UnitOfWork.SectionRepository.Delete(section);
        }

        public Section GetSectionById(int id)
        {
            return UnitOfWork.SectionRepository.GetById(id);
        }

        public IEnumerable<Section> Sections()
        {
            return UnitOfWork.SectionRepository.GetAll();
        }
    }
}