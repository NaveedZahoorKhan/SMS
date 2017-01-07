using System;

namespace SMS.Model.Models
{
    public class Course : ModelDefault
    {

        public TimeSpan TimeSpan { get; set; }

        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}