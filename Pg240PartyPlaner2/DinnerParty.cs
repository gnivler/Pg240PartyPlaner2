using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg240PartyPlaner2 {
    class DinnerParty : Party {

        public DinnerParty(int numberOfGuests, bool alcohol, bool fancyDecorations) {
            NumberOfGuests = numberOfGuests;
            Alcohol = alcohol;
            FancyDecorations = fancyDecorations;
        }

        public bool Alcohol { get; set; }

        override public decimal Cost {
            get {
                decimal totalCost = base.Cost;
                totalCost += CalcCostOfDrinks(Alcohol);
                if (Alcohol)
                    return totalCost;
                else
                    return totalCost + 25M * 0.95M;
            }
        }

        private decimal CalcCostOfDrinks(bool alcohol) {
            if (alcohol) {
                return NumberOfGuests * 20M;
            } else {
                return NumberOfGuests * 5M;
            }
        }
    }
}   