using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEx.Data.Infrastructure
{
   public class DbFactory : Disposable, IDbFactory
    {
        private ShopExDbContext dbContext;
        public ShopExDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopExDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
