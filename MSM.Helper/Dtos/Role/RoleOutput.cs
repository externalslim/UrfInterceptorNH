using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.Role
{
    public class RoleOutput : BaseEntity
    {
        public List<RoleDto> RoleListModel { get; set; }
        public RoleDto RoleModel { get; set; }
    }
}
