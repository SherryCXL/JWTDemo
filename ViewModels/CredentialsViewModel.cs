using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2_2JWTDemo.ViewModels.Validations;
using FluentValidation.Validators;
using FluentValidation.Attributes;

namespace WebAPI2_2JWTDemo.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
