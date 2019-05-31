using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.SendList
{
    public class SendListOutput : BaseEntity
    {
        public List<SendListDto> SendListListModel { get; set; }
        public SendListDto SendListModel { get; set; }
    }
}
