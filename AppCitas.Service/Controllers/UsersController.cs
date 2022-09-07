using AppCitas.Service.Data;
using AppCitas.Service.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace AppCitas.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    // GET api/users
    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        var users = _context.Users.ToList();

        return users;

    }

    // GET aí/usaers/{id}
    [HttpGet("{id}")]
    public ActionResult<AppUser> GetUserById(int id)
    {
        var users = _context.Users.Find(id);

        return users;

    }
}
