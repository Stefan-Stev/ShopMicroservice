using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShopFeature.Commands
{
    public class UpdateShopCommand:IRequest<int>
    {
        public int Id { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public string Name { get; set; }

    }
}
