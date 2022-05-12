using System.Linq;

namespace hi_low_game
{
    class Deck{
        Random random = new Random();

        int[] cardsArray = new int[13];
        int cardsArray_Length = 13;



        public Deck(){}


        // Defines the initial set of cards in the deck - Sam
        public void initializeCardsArray(){
            cardsArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            Deck_Shuffle(); // shuffles deck of cards - Doug
            Console.WriteLine("-Reshuffling Deck-");
        }
        public int[] Deck_Shuffle(){ // shuffles deck
            cardsArray = cardsArray.OrderBy(x => random.Next()).ToArray(); // randomly rearranges the cardsArray values. - Doug
            return cardsArray; // returns the shuffled cardsArray - Doug
        }
        public int Draw_Card(){
            if(cardsArray.Length == 0) // Reinitializes cardsArray if deck is exhausted - Doug
            {
               initializeCardsArray(); // reinitializes deck - Doug
               cardsArray_Length = 13; // resets current deck size - Doug
            }

            int card = cardsArray[(cardsArray.Length)-1]; // selects current highest array index as card to be drawn - Doug
            cardsArray_Length -= 1; // reduces the size of the deck by 1. - Doug
            Array.Resize(ref cardsArray, cardsArray_Length); // resizes the deck of cards array to match the current number of remaining cards. - Doug
            // Console.WriteLine($"Array length: {cardsArray.Length}"); // test code. - Doug
            return card; // returns the card value as an int - Doug
        }






    }
}