using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.SMSTemplateSchema
{
    public class SMSTemplateSchemaDto : BaseEntity
    {
        public int SMSTemplateGroupId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
    }
}
