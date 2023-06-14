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

            for(int i = 1; i < 8; i++)
            {
                if( curentlyPositionY + curentlyPositionY+1 < 8)
                resolut = resolut+ $"{curentlyPositionX},{curentlyPositionY+i}. ";

                if (curentlyPositionY + curentlyPositionY - 1 >= 0)
                    resolut = resolut + $"{curentlyPositionX},{curentlyPositionY - i}. ";
            }
            for (int i = 1; i < 8; i++)
            {
                if( curentlyPositionX + curentlyPositionX+1 < 8)
                resolut = resolut + $"{curentlyPositionX+i},{curentlyPositionY }. ";

                if (curentlyPositionX + curentlyPositionX - 1 >= 0)
                    resolut = resolut + $"{curentlyPositionX - i},{curentlyPositionY}. ";

            }





            return resolut;

        }
        
    }
}
