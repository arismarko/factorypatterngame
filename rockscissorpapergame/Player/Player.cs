using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockscissorpapergame.Player
{
    public abstract class Player
    {
        private string Name;

        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

       
    }
}
