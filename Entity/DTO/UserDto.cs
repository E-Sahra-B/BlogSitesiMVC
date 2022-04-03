using Entity.Concrete;

namespace Entity.DTO
{
    public class UserDto : AppUser
    {
        public string Password { get; set; }
        public string PasswordAgain { get; set; }
    }
}
