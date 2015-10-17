using rockscissorpapergame.Player;
using rockscissorpapergame.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockscissorpapergame.Game
{
    class RpcGame
    {
        private IPlayer player1;
        private IPlayer player2;

        #region Public methods

        /******************************
        /* 
        /*  The StartGame that is called 
        / *  from RockPaperScissorGame 
        /*
        / * ******************************/
        public void startGame() {
          
           string gameOption;
           bool continueToGame = true;

           do
           {
               //Set Game Options
               gameOption = createOptions();

               //Check if it is a valid option
               if (isValid(gameOption))
               {
                   //Did the use selected to Exit?
                   continueToGame = isExit(gameOption);

                   if (continueToGame)
                   {
                       //Set the Players of this game
                       setPlayers(gameOption);

                       //Play the game  
                       playGame();

                       //Do we want to play more?
                       continueToGame = playAgain();
                   }
                   else
                   {
                       //if the user selected to exit finish the loop
                       continueToGame = false;
                   }
               }
               else
               {
                   Console.Out.WriteLine("Not a valid option");
               }

           } while (continueToGame);
        }

        #endregion

        #region Privatemethods

        /******************************
         * 
        /*  Create the options of the game
        /
         * ******************************/
        private string createOptions()
        {
            string option;
            
            //Create the players --- method call --getOptions
            Console.Out.WriteLine("Game options");
            Console.Out.WriteLine("Press 1 and Enter for Human vs PC");
            Console.Out.WriteLine("Press 2 and Enter for  PC vs PC");
            Console.Out.WriteLine("Press 3 and Enter to Exit");
            Console.Out.WriteLine(" ");

            option = Console.ReadLine();

            return option;
        }

        /******************************
        * 
       /*  Set Action play or not?
       /*
        * ******************************/
        private bool isExit(string option)
        {
           return (option.Equals("1") || option.Equals("2"))? true : false;
        }

        /***********************************
         * 
         *  Is this a valid action
         * 
         **********************************/

        private bool isValid(string option)
        {
            return (option == "1" || option == "2" || option =="3")? true:false;
        }


        /******************************
        /* 
        /*  Set Players
        /*
        /* ******************************/
        private void setPlayers(string option)
        {
            switch (option)
            {
                case "1": // Tie
                    Player1 = PlayerFactory.getPlayerObj("human", "User");
                    Player2 = PlayerFactory.getPlayerObj("pc", "PC");
                    break;
                case "2": // User wins
                    Player1 = PlayerFactory.getPlayerObj("pc", "PC1");
                    Player2 = PlayerFactory.getPlayerObj("pc", "PC2");
                    break;
            }
           
        }

        /******************************
         * 
        /*  Play the game
        /*
         * ******************************/
        private void playGame()
        {
            int result = 0;

            Move user1Move = Player1.getMove();
            Move user2Move = Player2.getMove();
            Console.Out.WriteLine(" ");
            Console.Out.WriteLine(player1.name + " Played " + user1Move + ".");
            Console.Out.WriteLine(player2.name + " Played " + user2Move + ".");
            Console.Out.WriteLine(" ");
            result = compareMoves(user1Move, user2Move);

            switch (result)
            {
                case 0: // Tie
                    Console.Out.WriteLine("Tie!");
                    break;
                case 1: // User wins
                    Console.Out.WriteLine(player1.name + " beats " + player2.name);
                    break;
                case -1: // Computer wins
                    Console.Out.WriteLine(player1.name + " beats " + player2.name);
                    break;
            }
        }

        
        /******************************
         * 
        /*  Compare moves
        /*
         * ******************************/
        private int compareMoves(Move a, Move b)
        {
            // Tie
            if (a.Equals(b))
                return 0;

            switch (a)
            {
                case Move.ROCK:
                    return (b == Move.SCISSORS ? 1 : -1);
                case Move.PAPER:
                    return (b == Move.ROCK ? 1 : -1);
                case Move.SCISSORS:
                    return (b == Move.PAPER ? 1 : -1);
            }

            // Should never reach here
            return 0;
        }


        /******************************
         * 
        /*  Play Again
        /*
         * ******************************/
        private bool playAgain() {
            Console.Out.WriteLine(" ");
            Console.Out.WriteLine("Do you want to play again? Y for Yes or N for No  ");
            String userInput = Console.ReadLine();
            Console.Out.WriteLine(" ");
            
            string userChoice = userInput[0].ToString().ToLower();

            if (userChoice == "y")
            {
                return true;
            }
            else if(userChoice =="n")
            {
                return false;
            }
            else
            {
               return playAgain();
            }
            
        }


        #endregion

        #region Properties 

        public IPlayer Player1
        {
            get
            {
                return player1;
            }
            set
            {
                this.player1 = value;
            }
        }

        public IPlayer Player2
        {
            get
            {
                return player2;
            }
            set
            {
                this.player2 = value;
            }
        }

        #endregion


    }
}
