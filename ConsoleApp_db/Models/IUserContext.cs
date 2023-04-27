using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_db.Models;

public interface IUserContext
{
    DbSet<User> Users { get; set; }
}