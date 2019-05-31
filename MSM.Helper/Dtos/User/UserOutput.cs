using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.User
{
    public class UserOutput : BaseEntity
    {
        public List<UserDto> UserListModel { get; set; }
        public UserDto UserModel { get; set; }
    }
}
