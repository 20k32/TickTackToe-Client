using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Model.GameLogic
{
    internal sealed class Player
    {
        public string Name;
        public TickTackType Type;

        public Player(TickTackType type)
        {
            Type = type;
        }
    }
}
