using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class GamePlayMechanic
    {

       public List<Figure> theBoard = new List<Figure>();
            
       public GamePlayMechanic() {

            //dodanie białych figur

            for (int i = 0; i < 8; i++)// dodanie białych pawn 
            {
                theBoard.Add(new Pawn(1, i, true));
            }

            theBoard.Add(new Rook(0,0, true));//dodanie białych wież
            theBoard.Add(new Rook(0,7, true));

            theBoard.Add(new Bishop(0,2, true));// dodanie goniców
            theBoard.Add(new Bishop(0,5, true));

            theBoard.Add(new Knight(0,1,true));//dodanie skoczka
            theBoard.Add(new Knight(0,6,true));

            theBoard.Add(new King(0,4, true));//dodanie krula

            theBoard.Add(new Queen(0,3,true));//dodanie królowej



            //dodanie czarnych figur

            for (int i = 0; i < 8; i++)// dodanie czarnych pawn 
            {
                theBoard.Add(new Pawn(6, i, false));
            }
            theBoard.Add(new Rook(7, 0, false));//dodanie białych wież
            theBoard.Add(new Rook(7, 7, false));

            theBoard.Add(new Bishop(7, 2, false));// dodanie goniców
            theBoard.Add(new Bishop(7, 5, false));

            theBoard.Add(new Knight(7, 1, false));//dodanie skoczka
            theBoard.Add(new Knight(7, 6, false));

            theBoard.Add(new King(7, 4, false));//dodanie krula

            theBoard.Add(new Queen(7, 3, false));//dodanie królowej


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

        public int AllowedMove(int x, int y ) { return 1; }
        



    }
}
