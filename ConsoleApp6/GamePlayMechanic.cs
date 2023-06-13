using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class GamePlayMechanic
    {

       public List<Figure> theBoard = new List<Figure>();
            
       public GamePlayMechanic() {

            for (int i = 0; i < 8; i++)// dodanie białych pawn 
            {
                theBoard.Add(new Pawn(1, i, true));
    
            }
            for (int i = 0; i < 8; i++)// dodanie czarnych pawn 
            {
                theBoard.Add(new Pawn(6, i, false));


            }

        }
        public string CheckTheCell(int x , int y)
        {
            string result = " ";
            for (int k = 0; k < theBoard.Count; k++)
            {
                if(x == theBoard[k].curentlyPositionX && y == theBoard[k].curentlyPositionY)
                {
                     result= theBoard[k].kind;
                }
                    
            }
            return result;
                
        }

        public bool CheckTheColor(int x, int y)
        {
            bool result = false;
            for (int k = 0; k < theBoard.Count; k++)
            {
                if (x == theBoard[k].curentlyPositionX && y == theBoard[k].curentlyPositionY)
                {
                    result = theBoard[k].isWhite;
                }

            }
            return result;
        }
        



    }
}
