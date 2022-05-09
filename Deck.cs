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
        }
        public int Draw_Card(){
            int[] Deck_Shuffled = cardsArray.OrderBy(x => random.Next()).ToArray();
            int card = Deck_Shuffled[(Deck_Shuffled.Length)-1];
            cardsArray_Length = cardsArray_Length-1;
            Array.Resize(ref Deck_Shuffled, cardsArray_Length);
            return card;
        }






    }
}