using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Pawn : Figure
    {
        public bool firstMove;
        public Pawn( int x, int y, bool w) {
        
            isWhite= w;
            kind = "P";
            curentlyPositionX = x;
            curentlyPositionY = y;
            firstMove = false;
        
        }

        public override int AllowedMove()
        {

            return 43;   

        }


    }
}
