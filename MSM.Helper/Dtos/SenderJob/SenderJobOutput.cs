using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.SenderJob
{
    public class SenderJobOutput : BaseEntity
    {
        public List<SenderJobDto> SenderJobListModel { get; set; }
        public SenderJobDto SenderJobModel { get; set; }
    }
}
