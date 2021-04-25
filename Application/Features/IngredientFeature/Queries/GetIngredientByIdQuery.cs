using Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.IngredientFeature.Queries
{
    public class GetIngredientByIdQuery:IRequest<GetIngredientDto>
    {
        public int Id { get; set; }
    }
}
