using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;
using zad6_1.Configuration;

namespace zad6_1.Data;

public class BookDBContext : DbContext
{
    public DbSet<Book>? books {get;set;}

    public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
    }
}