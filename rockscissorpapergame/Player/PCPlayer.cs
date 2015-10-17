using rockscissorpapergame.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockscissorpapergame.Player
{
    public class PCPlayer: Player, IPlayer
    {
        #region IPlayer Members

        Move IPlayer.getMove()
        {

            Array values = Enum.GetValues(typeof(Move));
            Random random = new Random();
            Move randomMove = (Move)values.GetValue(random.Next(values.Length));

            return randomMove;
        }

        #endregion



    }
}
