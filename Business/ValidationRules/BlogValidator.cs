using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen {0} karakterden daha uzun başlık ekleyiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen {0} karakterden daha kısa başlık ekleyiniz");
        }
    }
}
