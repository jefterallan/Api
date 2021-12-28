using ApiSample.Data.Models;
using FluentValidation;

namespace ApiSample.Services.Dto.Validations
{
    public class Validation<T> : AbstractValidator<T> where T : Model
    {
        public Validation()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Message")
                .NotNull()
                .WithMessage("Message");
                //.Must(Validator)      -- call a function that always returns bool, inside the method check the rules for that field
                //.Lentgh(1,2)          -- use this to check if the leght is in min(1) and max(2)
                //.Matches(REGEX)       -- use this to check if the field attends to REGEX (declared in a const)
                //.IsInEnum()           -- use this to check if the enum property is a valid Enum
        }

        //use this with .Must(Method)
        public bool Validator(string a)
        {
            return true;
        }
    }
}
