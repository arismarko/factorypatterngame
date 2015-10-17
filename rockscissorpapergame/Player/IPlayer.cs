using rockscissorpapergame.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockscissorpapergame.Player
{
   public interface IPlayer
    {
       string name { get; set; }

       Move getMove();

      
    }
}
