using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingCardInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Card firstCard = new Card("Ace", "Spades");
            Card secondCard = new Card("Jack", "Diamonds");
            Card thirdCard = new Card("Queen", "Hearts");
            // print the cards in reverse order
            Console.WriteLine(thirdCard.Rank + " of " + thirdCard.Suit);
            Console.WriteLine(secondCard.Rank + " of " + secondCard.Suit);
            Console.WriteLine(firstCard.Rank + " of " + firstCard.Suit);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    class Card
    {
        #region Fields
        string rank;
        string suit;
        bool faceUp;
        #endregion
        #region Constructors
        /// <summary>
        /// Constructs a card with the given rank and suit
        /// </summary>
        /// <param name="rank">rank</param>
        /// <param name="suit">suit</param>
        public Card(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
            faceUp = false;
        }
        #endregion
        #region Properties
        /// <summary>
        /// Gets the card rank
        /// </summary>
        public string Rank
        {
            get { return rank; }
        }
        /// <summary>
        /// Gets the card suit
        /// </summary>
        public string Suit
        {
            get { return suit; }
        }
        /// <summary>
        /// Gets whether or not the card is face up
        /// </summary>
        public bool FaceUp
        {
            get { return faceUp; }
        }
        #endregion
        #region Public methods
        /// <summary>
        /// Flips the card over
        /// </summary>

        public void FlipOver()
        {
            faceUp = !faceUp;
        }
        #endregion
    }
}
