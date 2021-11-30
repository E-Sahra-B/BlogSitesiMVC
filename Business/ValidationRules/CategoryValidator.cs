using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Lütfen {0} karakterden daha uzun kategori adı ekleyiniz");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Lütfen {0} karakterden daha kısa kategori adı ekleyiniz");
        }
    }
}