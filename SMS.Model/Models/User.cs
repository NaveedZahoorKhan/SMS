using System.Collections.Generic;
using SMS.Common.Enums;

namespace SMS.Model.Models
{
    public class User : ModelBase
    {
        public UserType UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public GenderType Gender { get; set; }
        public string CnicOrPassport { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Phone { get; set; }

        #region Entity (Has One)

        public virtual Student Student { get; set; }

        public virtual Teacher Teacher { get; set; }
        #endregion


        #region Entity (Has Many)

        public virtual List<News> News { get; set; }

        #endregion
    }
}