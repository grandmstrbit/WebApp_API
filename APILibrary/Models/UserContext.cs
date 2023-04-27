using Microsoft.EntityFrameworkCore;

namespace APILibrary.Models;

/// <summary>
/// Class UsersContext.
/// Implements the <see cref="DbContext" />
/// Implements the <see cref="APILibrary.Models.IUserContext" />
/// </summary>
/// <seealso cref="DbContext" />
/// <seealso cref="APILibrary.Models.IUserContext" />
public class UsersContext : DbContext, IUserContext
{
    /// <summary>
    /// Gets or sets the users.
    /// </summary>
    /// <value>The users.</value>
    public DbSet<User> Users { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UsersContext"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public UsersContext(DbContextOptions<UsersContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}