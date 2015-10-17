using rockscissorpapergame.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockscissorpapergame.Player
{
    public class HumanPlayer:Player,IPlayer
    {
        #region IPlayer Members

        public Move getMove()
        {
            // Prompt the user
            Console.Out.WriteLine(" ");
            Console.Out.WriteLine("Rock, paper, or scissors?");
            Console.Out.WriteLine("Type R for Rock");
            Console.Out.WriteLine("Type P for Paper");
            Console.Out.WriteLine("Type S for Scissors");
            Console.Out.WriteLine(" ");

            string userInput = Console.ReadLine();

            string firstLetter = userInput[0].ToString().ToLower();
            
            //Check if the input is not empty
            if (!string.IsNullOrEmpty(userInput))
            {
                if (firstLetter == "r" || firstLetter == "p" || firstLetter == "s")
                {
                    // User has entered a valid input
                    switch (firstLetter)
                    {
                        case "r":
                            return Move.ROCK;
                        case "p":
                            return Move.PAPER;
                        case "s":
                            return Move.SCISSORS;
                    }
                }
            }
    
            // User has not entered a valid input. Prompt again.
            return getMove();
        }

        #endregion

        
    }
}
