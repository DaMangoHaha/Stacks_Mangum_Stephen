using System;
using System.Collections.Generic;

namespace Stacks_Mangum_Stephen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an array of Card objects representing a deck
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Diamonds"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds"),
            };

            // Initializes a stack (using LIFO) of cards using the array
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            // Displays all cards currently in the deck
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($" {card.Number} of {card.Suit}");
            }

            // Shows the number of cards in the stack
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            // Creates a list to represent the player's hand and add some cards to it
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            // Simulates asking for an "8" and drawing a card from the deck if available
            Console.WriteLine("Got any 8's?");
            if (startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop()); // Removes the top card from the stack and add it to the hand
            }

            // Shows the updated number of cards in the stack
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            // Places the first card from the hand back onto the top of the stack
            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            // Displays all cards currently in the deck after changes
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($" {card.Number} of {card.Suit}");
            }

        }
    }
}

