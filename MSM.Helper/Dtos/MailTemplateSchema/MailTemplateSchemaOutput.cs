using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.MailTemplateSchema
{
    public class MailTemplateSchemaOutput : BaseEntity
    {
        public List<MailTemplateSchemaDto> MailTemplateSchemaListModel { get; set; }
        public MailTemplateSchemaDto MailTemplateSchemaModel { get; set; }
    }
}
