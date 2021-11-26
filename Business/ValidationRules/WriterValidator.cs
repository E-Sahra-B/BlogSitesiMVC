using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mail boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifre boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı en az {0} karakter");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı en fazla {0} karakter");
        }
    }
}
