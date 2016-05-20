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
            NumberOfGuests = NumberOfGuests;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }


    }
}