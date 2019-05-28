using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.FromListGroup
{
    public class FromListGroupOutput : BaseEntity
    {
        public List<FromListGroupDto> FromListGroupListModel { get; set; }
        public FromListGroupDto FromListGroupModel { get; set; }
    }
}
