using MSM.Helper.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSM.Helper.Dtos.SMSTemplate
{
    public class SMSTemplateInput : BaseEntity
    {
        public int UserId { get; set; }
        public int SMSTemplateGroupId { get; set; }
        public string Name { get; set; }
    }
}
