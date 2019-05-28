using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.Person
{
    public class PersonInput : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
