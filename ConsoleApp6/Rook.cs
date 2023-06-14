using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Rook : Figure
    {
        public bool firstMove;
        public Rook(int x, int y, bool w)
        {

            isWhite = w;
            kind = "R";
            curentlyPositionX = x;
            curentlyPositionY = y;
            firstMove = false;

        }
        public override string AllowedMove()
        {
            string resolut = "";
            return resolut;

        }
    }
}
