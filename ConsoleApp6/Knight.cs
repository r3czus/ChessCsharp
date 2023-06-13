using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Knight : Figure
    {
       
            public Knight(int x, int y, bool w)
            {

                isWhite = w;
                kind = "H";
                curentlyPositionX = x;
                curentlyPositionY = y;
               

            }
        public  override int AllowedMove()
        {

            return 43;

        }
    }
}
