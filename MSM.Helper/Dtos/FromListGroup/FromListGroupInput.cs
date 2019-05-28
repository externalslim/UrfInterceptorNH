using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.FromListGroup
{
    public class FromListGroupInput : BaseEntity
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
    }
}
