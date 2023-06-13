using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class King : Figure
    {
        public bool firstMove;

        public King(int x, int y, bool w)
        {

            isWhite = w;
            kind = "K";
            curentlyPositionX = x;
            curentlyPositionY = y;
            firstMove = false;

        }
    }
}
