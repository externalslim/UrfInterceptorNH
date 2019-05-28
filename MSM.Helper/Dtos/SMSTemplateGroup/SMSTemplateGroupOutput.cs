using MSM.Helper.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSM.Helper.Dtos.SMSTemplateGroup
{
    public class SMSTemplateGroupOutput : BaseEntity
    {
        public List<SMSTemplateGroupDto> SMSTemplateGroupListModel { get; set; }
        public SMSTemplateGroupDto SMSTemplateGroupModel { get; set; }
    }
}
