using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Model.Models
{
    public class Student 
    {
        [Key, ForeignKey("User")]
        public int StudentId { get; set; }
        [ForeignKey("Section")]
        public int SectionId { get; set; }

        #region Foreign Keys

        public virtual User User { get; set; }
        public virtual Section Section { get; set; }
        #endregion
    }
}