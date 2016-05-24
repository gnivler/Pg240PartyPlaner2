using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg240PartyPlaner2 {
    class BirthdayParty {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfGuests { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfGuests, bool fancyDecorations, string cakeWriting) {
            NumberOfGuests = numberOfGuests;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        public bool CakeWritingTooLong {
            get {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        public decimal Cost {
            get {
                decimal totalCost = CalcCostOfDecos();
                decimal cakeCost;
                totalCost += CostOfFoodPerPerson * NumberOfGuests;
                if (NumberOfGuests > 12)
                    totalCost += 100M;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * 0.25M;
                else
                    cakeCost = 75M + ActualLength * 0.25M;
                return cakeCost + totalCost;
            }
        }

        private int ActualLength {
            get {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private decimal CalcCostOfDecos() {
            if (FancyDecorations)
                return (NumberOfGuests * 15.00M) + 50M;
            else
                return (NumberOfGuests * 7.50M) + 30M;
        }

        private int CakeSize() {
            if (NumberOfGuests <= 4)
                return 8;
            else
                return 16;
        }

        private int MaxWritingLength() {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }
    }
}