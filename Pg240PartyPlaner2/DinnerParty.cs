using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg240PartyPlaner2 {
    class DinnerParty {

        public DinnerParty(int numberOfGuests, bool alcohol, bool fancyDecorations) {
            NumberOfGuests = numberOfGuests;
            Alcohol = alcohol;
            FancyDecorations = fancyDecorations;
        }

        // properties
        public int NumberOfGuests { get; set; }
        public bool FancyDecorations { get; set; }
        public bool Alcohol { get; set; }
        public decimal Cost {
            get {
                decimal totalCost = CalcCostOfDeco(FancyDecorations) + CalcCostOfDrinks(Alcohol) + (NumberOfGuests * 25M);
                if (NumberOfGuests > 12)
                    totalCost += 100M;
                if (Alcohol)
                    return totalCost;
                else
                    return totalCost * 25M * 0.95M;
            }
            set {
                Cost = value;
            }
        }

        private decimal CalcCostOfDeco(bool fancy) {
            if (fancy) {
                return NumberOfGuests * 15M + 50;
            } else {
                return NumberOfGuests * 7.5M + 30;
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