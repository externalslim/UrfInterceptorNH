using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.SMSTemplateSchema
{
    public class SMSTemplateSchemaOutput : BaseEntity
    {
        public List<SMSTemplateSchemaDto> SMSTemplateSchemaListModel { get; set; }
        public SMSTemplateSchemaDto SMSTemplateSchemaModel { get; set; }
    }
}
