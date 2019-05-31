using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.MailTemplateSchema
{
    public class MailTemplateSchemaDto : BaseEntity
    {
        public int MailTemplateGroupId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
