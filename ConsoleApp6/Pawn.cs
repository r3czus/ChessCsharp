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

        public override string AllowedMove() //sprawdzanie wszystkich dostępnych ruchów dla  pionka 
        {
            string result="";

            if (!firstMove)
            {
                if(isWhite)
                {
                     result = $"{curentlyPositionX},{curentlyPositionY + 2}.";
                    
                }
                else
                {
                    result = $"{curentlyPositionX},{curentlyPositionY - 2}.";
                }
            }

                if (isWhite)
                {
                    result = result + $"{curentlyPositionX},{curentlyPositionY + 1}.";
                }
                else
                {
                    result = result + $"{curentlyPositionX},{curentlyPositionY - 1}.";
                }
            
            return result;

        }


    }
}
