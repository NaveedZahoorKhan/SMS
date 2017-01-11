using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Model.Models
{
    public class TimeTable 
    {
        [Key,ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }


        public TimeSpan TimeSpan { get; set; }


        #region Has Many

        public List<Course> Courses { get; set; }
        public Course Course { get; set; }
        #endregion
    }
}