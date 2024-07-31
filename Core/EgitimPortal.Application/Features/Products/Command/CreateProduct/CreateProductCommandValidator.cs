using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandValidator:AbstractValidator<CreateProductCommandRequest>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.title)
            .NotEmpty()
            .WithName("Başlık");

            RuleFor(x => x.description)
                .NotEmpty()
                .WithName("Açıklama");

            RuleFor(x => x.price)
                .GreaterThan(0)
                .WithName("Fiyat");

            RuleFor(x => x.CategoryIds)
                .NotEmpty()
                .Must(categories => categories.Any())
                .WithName("Kategoriler");
        }
    }
}
