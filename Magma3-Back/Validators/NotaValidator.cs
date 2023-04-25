using FluentValidation;
using Magma3_Back.DTO;

namespace Magma3_Back.Validators
{
    public class NotaValidator : AbstractValidator<NotaDTO>
    {
        public NotaValidator()
        {
            RuleFor(n => n.Nome).NotEmpty();
            RuleFor(n => n.Email).NotEmpty().EmailAddress();
            RuleFor(n => n.Preco).GreaterThan(0);
            RuleFor(n => n.Data).NotEmpty();
        }
    }
}
