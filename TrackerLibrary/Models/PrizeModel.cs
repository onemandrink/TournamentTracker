using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }

        public int PlaceNumber { get; set; }

        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int tempPlaceNumber = 0;
            int.TryParse(placeNumber, out tempPlaceNumber);
            PlaceNumber = tempPlaceNumber;

            decimal tempPrizeAmount = 0;
            decimal.TryParse(prizeAmount, out tempPrizeAmount);
            PrizeAmount = tempPrizeAmount;

            double tempPrizePercentage = 0;
            double.TryParse(prizePercentage, out tempPrizePercentage);
            PrizePercentage = tempPrizePercentage;
        }
    }
}
