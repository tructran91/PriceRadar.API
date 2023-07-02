using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceRadar.Core.Entities
{
    public class Subscription: EntityBase
    {
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public double Value { get; set; }
    }
}
