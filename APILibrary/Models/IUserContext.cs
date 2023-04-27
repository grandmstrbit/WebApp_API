using Microsoft.EntityFrameworkCore;

namespace APILibrary.Models;

public interface IUserContext
{
    DbSet<User> Users { get; set; }
}