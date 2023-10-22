using ComputacionClase2_ChavezClara.Dtos;
using FluentValidation;

namespace ComputacionClase2_ChavezClara.Validator
{
    public class EditorialValidator : AbstractValidator<SaveEditorialDto>
    {
        public EditorialValidator() 
        { 
            RuleFor(x => x.Name)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(50)
                            .MinimumLength(10);
            RuleFor(x => x.NameContact)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(100)
                            .MinimumLength(10);
            RuleFor(x => x.Address)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(150)
                            .MinimumLength(10);
            RuleFor(x => x.City)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(50)
                            .MinimumLength(10);
            RuleFor(x => x.Phone)
                            .NotEmpty()
                            .NotNull()
                            .Length(12);
            RuleFor(x => x.Email)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(100)
                            .MinimumLength(10);
            RuleFor(x => x.Commentary)
                            .MaximumLength(150);
        }
    }
}
