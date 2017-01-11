using System.Collections.Generic;
using SMS.Model.Models;

namespace SMS.Services.Interfaces
{
    public interface ITeacherService : IService<Teacher>
    {
        void CreateTeacher(Teacher teacher);
        void CreateTeachers(IEnumerable<Teacher> teachers);
        void DeleteTeacher(Teacher teacher);
        Teacher GeTeacherById(int id);
        IEnumerable<Teacher> GetAllTeachers();
        void SaveTeacher();
    }
}