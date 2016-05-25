using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg240PartyPlaner2 {
    class BirthdayParty : Party {
        public BirthdayParty(int numberOfGuests, bool fancyDecorations, string cakeWriting) {
            NumberOfGuests = numberOfGuests;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        public string CakeWriting { get; set; }
        public bool CakeWritingTooLong {
            get {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        override public decimal Cost {
            get {
                decimal totalCost = base.Cost;
                decimal cakeCost;
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