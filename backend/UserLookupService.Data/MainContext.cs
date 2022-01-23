using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UserLookupService.Data;

public class MainContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {

    }
