using MSM.Helper.Dtos.Base;
using System;

namespace MSM.Helper.Dtos.SenderJob
{
    public class SenderJobDto : BaseEntity
    {
        public string Name { get; set; }
        public int TemplateTypeId { get; set; }
        public int TemplateId { get; set; }
        public DateTime StartDate { get; set; }
        public int Counter { get; set; }
        public int SendPeriod { get; set; }
    }
}
