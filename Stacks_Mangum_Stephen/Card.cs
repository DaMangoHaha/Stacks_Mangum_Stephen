using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Mangum_Stephen
{
    // Represents a playing card with a number/face and a suit
    internal class Card
    {
        // The numbers or face value of the card (e.g., "Ace", "2", "King")
        public string Number { get; set; }

        // The suit of the card (e.g., "Hearts", "Spades")
        public string Suit { get; set; }

        // This is the constructor to initialize a card with a specific number and suit
        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}

