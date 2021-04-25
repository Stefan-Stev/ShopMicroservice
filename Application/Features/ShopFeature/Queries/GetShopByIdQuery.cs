﻿using Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShopFeature.Queries
{
    public class GetShopByIdQuery:IRequest<GetShopDto>
    {
        public int Id;
    }
}
