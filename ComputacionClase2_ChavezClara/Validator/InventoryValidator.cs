using ComputacionClase2_ChavezClara.Dtos;
using FluentValidation;

namespace ComputacionClase2_ChavezClara.Validator
{
    public class InventoryValidator : AbstractValidator<SaveInventoryDto>
    {
        public InventoryValidator() 
        {
            RuleFor(x => x.Existence)
                            .NotEmpty()
                            .NotNull();
            RuleFor(x => x.BookId)
                            .NotEmpty()
                            .NotNull();
            RuleFor(x => x.BranchId)
                            .NotEmpty()
                            .NotNull();
        }
    }
}
