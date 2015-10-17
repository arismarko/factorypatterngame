using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rockscissorpapergame.Game;

namespace rockscissorpapergame.Core
{
    class RockPaperScissorGame
    {
        static void Main(string[] args)
        {
            RpcGame RockPaperScissors = new RpcGame();
            RockPaperScissors.startGame();
        }

    }
}
