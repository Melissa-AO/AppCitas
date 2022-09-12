using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AppCitas.Service.Entities;

public class AppUser
{
    public int Id { get; set; }

    public string UserName { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PaswordSalt { get; set; }
}
