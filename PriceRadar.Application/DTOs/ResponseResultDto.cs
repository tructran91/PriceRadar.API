using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceRadar.Application.DTOs
{
    public class ResponseResultDto
    {
        public string error { get; set; }

        public string error_msg { get; set; }

        public DataModelDto data { get; set; }
    }

    public class DataModelDto
    {
        public int cmt_count { get; set; }

        public int historical_sold { get; set; }

        public double price_min { get; set; }

        public double price_max { get; set; }

        public double price { get; set; }

        public string image { get; set; }
    }
}
