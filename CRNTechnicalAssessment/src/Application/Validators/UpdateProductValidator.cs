using Application.DTOs;
using FluentValidation;

namespace Application.Validators
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Product Name is required.")
                .MaximumLength(255);

            RuleFor(x => x.ModifiedBy)
                .NotEmpty().WithMessage("ModifiedBy is required.")
                .MaximumLength(100);
        }
    }
}