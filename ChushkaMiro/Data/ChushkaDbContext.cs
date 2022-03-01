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
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}
