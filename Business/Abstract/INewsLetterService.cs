using Entity.Concrete;

namespace Business.Abstract
{
    public interface INewsLetterService : IGenericService<NewsLetter>
    {
        NewsLetter GetByMail(string mail);
    }
}
