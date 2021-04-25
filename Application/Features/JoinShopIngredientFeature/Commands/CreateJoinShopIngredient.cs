using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.JoinShopIngredientFeature.Commands
{
    public class CreateJoinShopIngredient:IRequest<bool>
    {
        public int ShopId { get; set; }
        public int IngrdientId { get; set; }
        public int Quantity { get; set; }

    }
}
