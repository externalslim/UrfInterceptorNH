using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.MailTemplate
{
    public class MailTemplateOutput : BaseEntity
    {
        public List<MailTemplateDto> MailTemplateListModel { get; set; }
        public MailTemplateDto MailTemplateModel { get; set; }
    }
}
