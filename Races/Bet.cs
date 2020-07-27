using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Races
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet(int Amount, int Dog, Guy which)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            Bettor = which;
        }

        public string GetDescription()
        {
            return "";
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return 2 * Amount;
            }
            else
            {
                return -Amount;
            }
        }



    }
}
