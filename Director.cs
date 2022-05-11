namespace hi_low_game
{
    class Director
    {
        public void StartGame()
        {
            Deck deck = new Deck();
            deck.initializeCardsArray();            
            int points = 300;

            bool keepPlaying = true;
            do
            {
                (bool RecievePoints, keepPlaying) = GetInputs();
                (points,keepPlaying) = DoUpdates(RecievePoints,points);
                DoOutputs(points);
            } while (keepPlaying);
        }
//get inputs from the user

        
        public static (bool,bool) GetInputs()
        {
            // needs to be able to set the inital card so that it's not in the loop
            Deck deck = new Deck();
            int initialCardValue = deck.Draw_Card(); //picks an initial card value - Tyler
            int CardToGuess = deck.Draw_Card(); // TALK TO DOUG ABOUT HOW TO INTEGRATE THIS WITH HIS CODE.

            Console.WriteLine(initialCardValue);//TEST CODE
            Console.WriteLine(CardToGuess); //TEST CODE


            Console.WriteLine($"The Card is {initialCardValue}"); //Print Card Value
            Console.WriteLine("Higher/Lower? [h/l/quit]"); //gets user input for card value
            string PlayerGuess = Console.ReadLine();


            if (PlayerGuess == null) {   // if the user does not put in a value it will take the null input and change it to a blank string
                PlayerGuess = string.Empty; 
            }

            
            if ((PlayerGuess.ToLower() == "h" && CardToGuess < initialCardValue)||(PlayerGuess.ToLower() == "l" && CardToGuess > initialCardValue)) {
                Console.WriteLine("You got it right!"); // Checks to see which letter the user inputed and to see if they got it correct. - Tyler
                return (true,true);
            }
            else if (PlayerGuess.ToLower()=="quit"){
               // Environment.Exit(0);  // quits the program, sends the error code 0 to the terminal. - Tyler- Better Code possible.
                return (false,false);
            }
            else{
                Console.WriteLine("You got it Wrong");  //if anything else is added it will it will return false. Their Guess is incorrect - Tyler
                return (false,true);
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
            if(TotalPoints == 0){
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
