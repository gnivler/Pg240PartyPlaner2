using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg240PartyPlaner2 {
    class Party {

        public int NumberOfGuests { get; set; }
        public bool FancyDecorations { get; set; }
        public const int CostOfFoodPerPerson = 25;



        virtual public decimal Cost {
            get {
                decimal totalCost = CalcCostOfDecos(FancyDecorations);
                totalCost += NumberOfGuests * CostOfFoodPerPerson;
                if (NumberOfGuests > 12)
                    totalCost += 100M;
                return totalCost;
            }
        }

        private decimal CalcCostOfDecos(bool fancy) {
            if (fancy) {
                return NumberOfGuests * 15M + 50M;
            } else {
                return NumberOfGuests * 7.5M + 30M;
            }
        }

    }
}