using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Core.Validation
{
    public class UserRegistrationValidation : AbstractValidator<UserRegistrationDTO>
    {
        protected readonly UserManager<User> _userManager;

        public UserRegistrationValidation(UserManager<User> userManager)
        {
            _userManager = userManager;

            RuleFor(user => user.Name)
                .NotNull()
                .NotEmpty()
                .Length(2, 50)
                .Matches(@"^\D*$").WithMessage("'{PropertyName}' must not contain digits!")
                .Matches(@"\A[A-Z][a-z]{1,49}[a-z]*$").WithMessage("The first letter in '{PropertyName}' must be uppercase, the others must be lowercase!")
                .Matches("^[^£# “”!@$%^&*(){}:;<>,.?/+_=|'~\\-]*$").WithMessage("'{PropertyName}' must not contain special characters!");

            RuleFor(user => user.Surname)
                .NotNull()
                .NotEmpty()
                .Length(2, 50)
                .Matches(@"^\D*$").WithMessage("'{PropertyName}' must not contain digits!")
                .Matches(@"\A[A-Z][a-z]{1,49}[a-z]*$").WithMessage("The first letter in '{PropertyName}' must be uppercase, the others must be lowercase!")
                .Matches("^[^£# “”!@$%^&*(){}:;<>,.?/+_=|'~\\-]*$").WithMessage("'{PropertyName}' must not contain special characters!");


            RuleFor(user => user.Email)
                .NotNull()
                .EmailAddress().WithMessage("'{PropertyValue}' - is not an email address!")
                .MustAsync(IsUniqueUserEmail).WithMessage("A user with this email ('{PropertyValue}') is already registered!");

            RuleFor(user => user.Password)
                .NotNull()
                .Length(8, 50)
                .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more uppercase letters!")
                .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters!")
                .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits!")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{PropertyName}' must contain one or more special characters!")
                .Matches("^[^£# “”]*$").WithMessage("'{PropertyName}' must not contain the following characters £ # “” or spaces!");
        }

        private async Task<bool> IsUniqueUserEmail(string email, CancellationToken cancellationToken)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            return userEntity == null;
        }
        //private async Task<bool> HasNumber(string val, CancellationToken cancellationToken)
        //{
        //    return await Task.Run(() => val.Any(char.IsNumber) == false);
        //}
    }
}
