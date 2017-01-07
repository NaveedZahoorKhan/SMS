using System;

namespace SMS.Model.Models
{
    public class ModelBase
    {

        public int Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}