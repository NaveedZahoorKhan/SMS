using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SMS.Common.Enums;
namespace SMS.Model.Models
{
    public class Teacher
    {
        [Key, ForeignKey("User")]
        public int TeacherId { get; set; }

        [ForeignKey("Section")]
        public int SectionId { get; set; }

      
        public TeacherType TeacherType { get; set; }


        #region Foreign Key
        public virtual User User { get; set; }
        public virtual Section Section { get; set; }

        #endregion

        #region Has Man

        public virtual List<Course> Courses { get; set; }
        public virtual Course Course { get; set; }

        #endregion


        }
}