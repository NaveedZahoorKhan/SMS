using System.ComponentModel;

namespace SMS.Model.Models
{
    public class ModelDefault : ModelBase
    {

        public string Code { get; set; }
        public string Title { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}