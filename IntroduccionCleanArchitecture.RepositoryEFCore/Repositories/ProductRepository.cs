using IntroduccionCleanArchitecture.Entities.Interfaces;
using IntroduccionCleanArchitecture.Entities.POCOs;
using IntroduccionCleanArchitecture.Repository.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly Context _context;
        public ProductRepository(Context context) => _context = context;
        
        public void CreateProduct(Product product)
        {
            _context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
