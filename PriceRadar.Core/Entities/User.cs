using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceRadar.Core.Entities
{
    public class User : EntityBase
    {
        public string? Name { get; set; }

        public string? Telephone { get; set; }

        public string? Note { get; set; }

        public Guid SubscriptionId { get; set; }

        public Subscription? Subscription { get; set; }
    }
}
