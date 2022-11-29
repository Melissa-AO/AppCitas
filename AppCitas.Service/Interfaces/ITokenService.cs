using AppCitas.Service.Entities;

namespace AppCitas.Service.Interfaces
{
    public class ITokenService
    {

        string CreateToken(AppUser user);
    }
}
