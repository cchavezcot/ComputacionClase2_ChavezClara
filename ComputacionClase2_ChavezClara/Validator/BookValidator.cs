using ComputacionClase2_ChavezClara.Dtos;
using FluentValidation;

namespace ComputacionClase2_ChavezClara.Validator
{
    public class BookValidator : AbstractValidator<SaveBookDto>
    {
        public BookValidator() 
        {
            RuleFor(x => x.ISBN)
                            .NotEmpty()
                            .NotNull()
                            .Length(13);
            RuleFor(x => x.Title)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(100)
                            .MinimumLength(10);
            RuleFor(x => x.Autor)
                            .NotEmpty()
                            .NotNull()
                            .MaximumLength(100)
                            .MinimumLength(10);
            RuleFor(x => x.Year)
                            .NotEmpty()
                            .NotNull();
            RuleFor(x => x.Price)
                            .NotEmpty()
                            .NotNull();
            RuleFor(x => x.Commentary)
                            .MaximumLength(150)
                            .MinimumLength(10);
            RuleFor(x => x.EditorialId)
                            .NotEmpty()
                            .NotNull();
        }
    }
}
