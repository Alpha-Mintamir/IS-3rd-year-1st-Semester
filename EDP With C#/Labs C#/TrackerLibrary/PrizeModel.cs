using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int PlaceNumber { get; set; }
        public string PublicName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PricePercentage { get; set; }
    }
}
