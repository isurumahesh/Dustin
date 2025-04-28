using Dustin.Application.DTOs;
using FluentValidation;

namespace Dustin.Application.Validators
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductDTO>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.BrandId).NotEmpty();
            RuleFor(x => x.SubCategoryId).NotEmpty();
            RuleForEach(x => x.ProductItems).SetValidator(new UpdateProductItemValidator());
        }
    }
}