namespace hi_low_game
{
    class Director
    {

        int score;
        bool correct;
        

        public void StartGame()
        {
            Deck deck = new Deck();
            deck.initializeCardsArray();            
            

            bool keepPlaying = true;
            do
            {
                GetInputs();
                // DoUpdates();
                DoOutputs();
            } while (keepPlaying);
        }
//get inputs from the user
        public void GetInputs()
        {
            return;
        }

        public void DoOutputs(){
            if (correct){
               Console.WriteLine("That's Correct!."); 
            }
            else{
                Console.WriteLine("Sorry that isn't correct.");
                
            }
            Console.WriteLine($"New score: {score}");

            return;
        }
    }
}
