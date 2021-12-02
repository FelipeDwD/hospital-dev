using System;

namespace Hospital.WebApi.Domain.Models
{
    public class ContactModel : BaseEntityModel
    {
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public Guid IdUser { get; set; }
        public virtual UserModel User { get; set; }

        public ContactModel()
        {

        }
        public ContactModel(string cellPhone, string email)
        {
            CellPhone = cellPhone;
            Email = email;
        }
    }
}
