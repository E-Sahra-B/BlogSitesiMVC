using Entity.Concrete;
using Entity.DTO;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBusinessUserService
    {
        Task RegisterUserAsync(AppUser T, string password);
        Task DeleteUserAsync(AppUser t);
        Task<AppUser> GetByIDAsync(string id);
        Task UpdateUserAsync(UserDto user);
        Task<UserDto> FindUserNameAsync(string userName);
    }
}
