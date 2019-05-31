using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.SendList
{
    public class SendListDto : BaseEntity
    {
        public int SenderJobId { get; set; }
        public int DataPoolId { get; set; }
    }
}
