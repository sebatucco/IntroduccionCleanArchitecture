using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.Repository.EFCore.DataContext
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
           var OptionBuilder = new DbContextOptionsBuilder<Context>();
            OptionBuilder.UseSqlServer("Data Source = DESKTOP-0KJ2PDV; Initial Catalog=IntroduccionCleanArchitecture; Integrated Security=true; TrustServerCertificate=True");
            return new Context(OptionBuilder.Options);
        }
    }
}
