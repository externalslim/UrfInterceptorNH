using System;

namespace MSM.Data.NhDatabase.NhModels
{
    public class Entity
    {
        public virtual int Id { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual int? UpdatedBy { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}
