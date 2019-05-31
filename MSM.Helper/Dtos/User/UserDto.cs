using MSM.Helper.Dtos.Base;

namespace MSM.Helper.Dtos.User
{
    public class UserDto : BaseEntity
    {
        public int PersonId { get; set; }
        public int ProjectId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
