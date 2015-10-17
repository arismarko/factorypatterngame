using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockscissorpapergame.Player
{
    public class PlayerFactory
    {
         public static IPlayer getPlayerObj(string userChoice, string name)
        {

            IPlayer objPlayer = null;

            //Create a different object based on  user choice.
            switch (userChoice.ToLower())
            {
                case "pc": // Tie
                    objPlayer = new PCPlayer();
                    objPlayer.name = name;
                    break;
                case "human": // User wins
                    objPlayer = new HumanPlayer();
                    objPlayer.name = name;
                    break;
                default:

                    break;
            }
   
           
            return objPlayer;
        }
    }
}
