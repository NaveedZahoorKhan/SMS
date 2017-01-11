using System.Collections.Generic;

namespace SMS.Model.Models
{
    public class Class : ModelDefault
    {


        #region Has Many

        public List<Course> Courses { get; set; }
        
        

        public List<Section> Sections { get; set; }
        #endregion
    }
}