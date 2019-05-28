using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.DataPool
{
    public class DataPoolInput : BaseEntity
    {
        public int FromListGroupId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
