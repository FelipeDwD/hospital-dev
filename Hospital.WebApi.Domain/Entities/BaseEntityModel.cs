using System;

namespace Hospital.WebApi.Domain.Entities
{
    public class BaseEntityModel
    {
        public Guid Id { get; set; }

        public BaseEntityModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
