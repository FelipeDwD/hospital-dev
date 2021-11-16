using System;

namespace Hospital.WebApi.Domain.Entities
{
    public class UserModel : BaseEntityModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid IdLogin { get; set; }
        public virtual LoginModel Login { get; set; }
        public Guid IdContact { get; set; }
        public ContactModel Contact { get; set; }
    }
}
