using Microsoft.EntityFrameworkCore;

// добавление данных
using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    User user1 = new User { Name = "Tom", Age = 33, Email = "bb@stud.kai.ru" };
    User user2 = new User { Name = "Alice", Age = 26, Email = "kk@stud.kai.ru" };

    // добавляем их в бд
    // db.Users.RemoveRange(user1, user2);
    // db.SaveChanges();
}
// получение данных
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Users list:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age} - {u.Email}");
    }
}

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=12345");
    }
}

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }
}