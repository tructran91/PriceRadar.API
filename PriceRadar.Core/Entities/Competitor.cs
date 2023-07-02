using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceRadar.Core.Entities
{
    public class Competitor : EntityBase
    {
        public string? Name { get; set; }

        public bool IsOwner { get; set; }

        public double? PriceManual { get; set; }

        public Guid ProducLinktId { get; set; }

        public ProductLink ProductLink { get; set; }
    }
}
