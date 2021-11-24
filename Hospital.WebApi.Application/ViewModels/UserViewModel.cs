using System;

namespace Hospital.WebApi.Application.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
