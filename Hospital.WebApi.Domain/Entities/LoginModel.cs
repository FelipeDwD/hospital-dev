using System;

namespace Hospital.WebApi.Domain.Entities
{
    public class LoginModel : BaseEntityModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid IdUser { get; set; }
        public virtual UserModel User { get; set; }
    }
}
