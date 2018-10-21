namespace TanoShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TanoShopDbContext dbContext;

        public TanoShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TanoShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}