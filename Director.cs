namespace hi_low_game
{
    class Director
    {
        public void StartGame()
        {
            Deck deck = new Deck();
            deck.initializeCardsArray();    
            int initialCardValue = deck.Draw_Card(); //picks an initial card value - Tyler        
            int points = 300;
            bool keepPlaying = true;

            do
            {
                (bool RecievePoints,initialCardValue) = GetInputs(initialCardValue,deck); // Gets to see if the player is correct, if 
                (points,keepPlaying) = DoUpdates(RecievePoints,points);
                DoOutputs(points);
            } while (keepPlaying);
        }
//get inputs from the user

        
        public static (bool,int) GetInputs(int initialCard, Deck deck)
        {
            
            int CardToGuess = deck.Draw_Card(); // Gets Card

            Console.WriteLine($"The Card is {initialCard}"); //Print Card Value
            Console.WriteLine("Higher/Lower? [h/l/quit]"); //gets user input for card value

            string PlayerGuess = Console.ReadLine();


            if (PlayerGuess == null) {   // if the user does not put in a value it will take the null input and change it to a blank string
                PlayerGuess = string.Empty; 
            }

            
            if ((PlayerGuess.ToLower() == "h" && CardToGuess > initialCard)||(PlayerGuess.ToLower() == "l" && CardToGuess < initialCard)) {
                Console.WriteLine("You got it right!"); // Checks to see which letter the user inputed and to see if they got it correct. - Tyler
                return (true,CardToGuess);
            }
            else if (PlayerGuess.ToLower()=="quit"){
                Environment.Exit(0);  // quits the program, sends the error code 0 to the terminal. - Tyler- Better Code possible.
                return (false,CardToGuess); // Sending another False to keepPlaying will Continue to run the program.
            }
            else{
                Console.WriteLine("You got it Wrong");  //if anything else is added it will it will return false. Their Guess is incorrect - Tyler
                return (false,CardToGuess);
            }
        }



        public static (int,bool)  DoUpdates(bool RecievePoints, int TotalPoints)
        {
            bool ContinuePlayin = true;
            int AddPoints;
            if (RecievePoints == true){
                AddPoints = 100;
            }
            else{
                AddPoints = -75;
            }
            
            
            TotalPoints = TotalPoints + AddPoints;
            if(TotalPoints <= 0){
                Console.WriteLine("You Lose");
                ContinuePlayin = false;
                    //ends the program and sends the error code zero to the system. - Tyler - Possible better code 
            }
            return (TotalPoints,ContinuePlayin);
        }



        public void DoOutputs(int points)
        {
            Console.WriteLine($"points: {points}");
            return;
        }

    }
}
