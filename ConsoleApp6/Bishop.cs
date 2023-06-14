using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Bishop: Figure
    {
        public Bishop(int x, int y, bool w)
        {

            isWhite = w;
            kind = "B";
            curentlyPositionX = x;
            curentlyPositionY = y;
            
        }
        public override string AllowedMove()
        {
            string resolut = "";
            return resolut;

        }
    }
}
