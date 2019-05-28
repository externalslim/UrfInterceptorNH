using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.SMSTemplate
{
    public class SMSTemplateDto : BaseEntity
    {
        public int UserId { get; set; }
        public int SMSTemplateGroupId { get; set; }
        public string Name { get; set; }
    }
}
