using System.Collections.Generic;
using ShopEx.Data.Infrastructure;
using ShopEx.Model.Models;
using System.Linq;

namespace ShopEx.Data.Repositories
{   
        public interface IProductCategoryRepository
        {
            IEnumerable<ProductCategory> GetByAlias(string alias);
        }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategory.Where(x => x.Alias == alias);
        }
    }
}
