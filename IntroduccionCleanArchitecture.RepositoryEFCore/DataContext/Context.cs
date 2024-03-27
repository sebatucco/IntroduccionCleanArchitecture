using IntroduccionCleanArchitecture.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.Repository.EFCore.DataContext
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Product> Products { get; set; }    
    }
}
