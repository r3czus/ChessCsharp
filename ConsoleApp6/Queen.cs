using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Queen : Figure
    {

        public Queen(int x, int y, bool w)
        {

            isWhite = w;
            kind = "P";
            curentlyPositionX = x;
            curentlyPositionY = y;
            

        }
    }
}
