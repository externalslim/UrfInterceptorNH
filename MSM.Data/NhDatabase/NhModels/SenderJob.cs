using System;

namespace MSM.Data.NhDatabase.NhModels
{
    public class SenderJob : Entity
    {
        public virtual string Name { get; set; }
        public virtual int TemplateTypeId { get; set; }
        public virtual int TemplateId { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual int Counter { get; set; }
        public virtual int SendPeriod { get; set; }
    }
}
