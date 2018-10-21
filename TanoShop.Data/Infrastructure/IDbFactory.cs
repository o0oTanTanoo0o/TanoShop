using System;

namespace TanoShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TanoShopDbContext Init();
    }
}