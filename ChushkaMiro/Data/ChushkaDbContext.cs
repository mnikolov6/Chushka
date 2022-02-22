using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChushkaMiro.Data
{
    public class ChushkaDbContext:DbContext
    {
        public ChushkaDbContext(DbContextOptions<ChushkaDbContext> op):base(op)
        {

        }
        DbSet<Users> Users { get; set; }
        DbSet<Products> Products { get; set; }
        DbSet<Orders> Orders { get; set; }
    }
}
