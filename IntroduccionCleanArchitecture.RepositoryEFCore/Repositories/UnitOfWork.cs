using IntroduccionCleanArchitecture.Entities.Interfaces;
using IntroduccionCleanArchitecture.Repository.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly Context _context;
        public UnitOfWork(Context context) => _context = context;
       
        public Task<int> Savechanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
