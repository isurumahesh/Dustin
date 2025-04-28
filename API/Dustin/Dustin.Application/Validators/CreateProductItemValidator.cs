using Dustin.Application.DTOs;
using FluentValidation;

namespace Dustin.Application.Validators
{
    internal class CreateProductItemValidator : AbstractValidator<CreateProductItemDTO>
    {
        public CreateProductItemValidator()
        {
            RuleFor(x => x.Sku).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Stock).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Price).GreaterThanOrEqualTo(0);
        }
    }
}