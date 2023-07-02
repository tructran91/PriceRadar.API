using PriceRadar.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceRadar.Core.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }

        public ProductType ProductType { get; set; }

        public string? SKU { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
