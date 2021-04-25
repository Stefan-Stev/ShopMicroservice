using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GetShopDto
    {
        public GetShopDto()
        {
            Ingredients = new List<GetIngredientDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        
        public List<GetIngredientDto> Ingredients { get; set; }
    }
}
