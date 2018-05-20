using System;

namespace ShopEx.Data.Infrastructure
{
   public interface IDbFactory : IDisposable
    {
        ShopExDbContext Init();
    }
}
