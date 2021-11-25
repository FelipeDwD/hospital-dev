using System;

namespace Hospital.WebApi.Domain.Models
{
    public class UserRoleModel : BaseEntityModel
    {
        public Guid IdUser { get; set; }
        public virtual UserModel User { get; set; }
        public Guid IdRole { get; set; }
        public virtual RoleModel Role { get; set; }
    }
}
