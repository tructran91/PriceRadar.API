using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceRadar.Core.Entities
{
    public class ProductLink
    {
        public int ShopId { get; set; }

        public int ItemId { get; set; }

        public string? Name { get; set; }

        public string Link { get; set; }

        public double? PriceMin { get; set; }

        public double? PriceMax { get; set; }

        public double? Price { get; set; }

        public int? HistoricalSold { get; set; }

        public int? CommentCount { get; set; }

        public string? Image { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
