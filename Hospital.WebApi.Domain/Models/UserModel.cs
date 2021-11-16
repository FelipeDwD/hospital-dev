using System;

namespace Hospital.WebApi.Domain.Models
{
    public class UserModel : BaseEntityModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public Guid IdLogin { get; set; }
        public virtual LoginModel Login { get; set; }
        public Guid IdContact { get; set; }
        public virtual ContactModel Contact { get; set; }
    }
}
