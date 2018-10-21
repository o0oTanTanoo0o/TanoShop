using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TanoShop.Data
{
    public class TanoShopDbSeed:DropCreateDatabaseAlways<TanoShopDbContext>
    {
        protected override void Seed(TanoShopDbContext context)
        {
        }
    }
}
