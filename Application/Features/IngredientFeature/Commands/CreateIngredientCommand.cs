using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.IngredientFeature.Commands
{
    public class CreateIngredientCommand : IRequest<int>
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}
