using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Model.Models
{
    public class Section : ModelBase
    {
        #region Foreign Keys
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }

        #endregion

        #region Has Many

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }
        #endregion
    }
}