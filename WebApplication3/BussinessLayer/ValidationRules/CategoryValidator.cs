using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public  class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategory adını boş geçemezsiniz. ");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz. ");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karekter girişi yapın.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karekter girişi yapın.");

        }

    }
}
