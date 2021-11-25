using System.Collections.Generic;

namespace Hospital.WebApi.Domain.Models
{
    public class RoleModel : BaseEntityModel
    {
        public string Name { get; set; }
        public virtual List<UserRoleModel> UserRoles { get; set; }
    }
}
