using ComputacionClase2_ChavezClara.Dtos;
using FluentValidation;

namespace ComputacionClase2_ChavezClara.Validator
{
    public class BranchValidator : AbstractValidator<SaveBranchDto>
    {
        public BranchValidator() 
        {
            RuleFor(x => x.BranchName)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(50)
                            .MinimumLength(10);
            RuleFor(x => x.ManagerName)
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
