using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.SMSTemplate
{
    public class SMSTemplateOutput : BaseEntity
    {
        public List<SMSTemplateDto> SMSTemplateListModel { get; set; }
        public SMSTemplateDto SMSTemplateModel { get; set; }
    }
}
