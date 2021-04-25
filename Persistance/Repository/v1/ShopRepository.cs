using Domain.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistance.Context;

namespace Persistance.Repository.v1
{
    public class ShopRepository : Repository<Shop>, IShopRepository
    {
        public ShopRepository(ShopContext shopContext) : base(shopContext)
        {
        }
    }
}
