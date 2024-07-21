using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adını boş geçemezsin");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Ürün adı en az 3 karakter");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat  boş geçilemez");
        }
    }
}
