using System;

namespace Hospital.WebApi.Domain.Models
{
    public abstract class BaseEntityModel
    {
        public Guid Id { get; set; }

        public BaseEntityModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
