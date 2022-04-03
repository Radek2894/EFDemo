using EFDemo.Models;
using Microsoft.EntityFrameworkCore;


    public class PeopleContext : DbContext
    {
    public PeopleContext(DbContextOptions options) : base(options) { }
    public DbSet<Person> Person { get; set; }
    
    }


