using System.Collections.Generic;
using SMS.Model.Models;

namespace SMS.Services.Interfaces
{
    public interface ISectionService : IService<Section>
    {
        void CreateSection(Section section);
        void UpdateSection(Section section);
        void DeleteSection(Section section);
        Section GetSectionById(int id);
        IEnumerable<Section> Sections();
        void SaveSection();
    }
}