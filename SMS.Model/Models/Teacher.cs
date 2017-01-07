using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SMS.Common.Enums;
namespace SMS.Model.Models
{
    public class Teacher
    {
        [Key, ForeignKey("User")]
        public string TeacherId;
        

        public TeacherType TeacherType { get; set; }


        #region Foreign Key
        public virtual User User { get; set; }
        

        #endregion


    }
}