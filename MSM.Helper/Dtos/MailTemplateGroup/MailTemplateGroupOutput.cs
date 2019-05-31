using MSM.Helper.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSM.Helper.Dtos.MailTemplateGroup
{
    public class MailTemplateGroupOutput : BaseEntity
    {
        public List<MailTemplateGroupDto> MailTemplateGroupListModel { get; set; }
        public MailTemplateGroupDto MailTemplateGroupModel { get; set; }
    }
}
