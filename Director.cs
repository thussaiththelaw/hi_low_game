namespace hi_low_game
{
    class Director
    {
        public void StartGame()
        {
            Deck deck = new Deck();
            deck.initializeCardsArray();            
            

            bool keepPlaying = true;
            do
            {
                GetInputs();
                // DoUpdates();
                // DoOutputs();
            } while (keepPlaying);
        }
//get inputs from the user
        public void GetInputs()
        {
            return;
        }
    }
}
