using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş bırakamazsınız");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık 150 karakteri geçemez");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Başlık 5 karakterden az olamaz");
        }
    }
}
