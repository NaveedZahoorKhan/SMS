namespace SMS.Model.Models
{
    public class News : ModelDefault
    {
        #region Foreign Keys (Belongs To)

        public int UserId { get; set; }
        public virtual User User {get; set;}
        #endregion
    }
}