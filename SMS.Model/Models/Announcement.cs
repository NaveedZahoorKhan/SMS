using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Model.Models
{
    public class Announcement  : ModelDefault
    {

        #region Foreign Keys
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        #endregion
    }
}