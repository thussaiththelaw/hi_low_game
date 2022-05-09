namespace hi_low_game
{
    class Director
    {
        public void StartGame()
        {
            bool keepPlaying = true;
            do
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            } while (keepPlaying);
        }
//get inputs from the user
        public void GetInputs()
        {
            return;
        }
    }
}
