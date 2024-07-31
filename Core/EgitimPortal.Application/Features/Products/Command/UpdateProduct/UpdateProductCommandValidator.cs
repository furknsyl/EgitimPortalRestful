using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandValidator:AbstractValidator<UpdateProductCommandRequest>
    {
        public UpdateProductCommandValidator()
        {

            RuleFor(x => x.Id)
            .GreaterThan(0);

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
