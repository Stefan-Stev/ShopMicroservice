using Application.Interfaces;
using Domain.Entities;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repository.v1
{
    public class IngredientRepository : Repository<IngredientsFromShop>, IIngredientRepository
    {
        public IngredientRepository(ShopContext shopContext) : base(shopContext)
        {
        }
    }
}
