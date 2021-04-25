using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public partial class IngredientFromShopShop
    {
        public int IngredientsId { get; set; }
        public int ShopsId { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public virtual IngredientsFromShop Ingredients { get; set; }
        [JsonIgnore]
        public virtual Shop Shops { get; set; }
    }
}
