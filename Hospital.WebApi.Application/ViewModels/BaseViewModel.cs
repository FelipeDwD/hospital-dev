using System.Collections.Generic;

namespace Hospital.WebApi.Application.ViewModels
{
    public abstract class BaseViewModel
    {
        public List<string> Notifications { get; set; }
    }
}
