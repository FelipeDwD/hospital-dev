﻿using Hospital.WebApi.Domain.Models;
using System.Collections.Generic;

namespace Hospital.WebApi.Domain.Interfaces.Services.Validations
{
    public interface IValidationService<T> where T : BaseEntityModel
    {
        List<string> Validate(T entity);
    }
}
