namespace TanoShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}