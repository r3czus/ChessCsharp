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
                theBoard.Add(new Pawn(i, 1, true));
            }

            theBoard.Add(new Rook(0,0, true));//dodanie białych wież
            theBoard.Add(new Rook(7,0, true));

            theBoard.Add(new Bishop(2,0, true));// dodanie goniców
            theBoard.Add(new Bishop(5,0, true));

            theBoard.Add(new Knight(1,0,true));//dodanie skoczka
            theBoard.Add(new Knight(6,0,true));

            theBoard.Add(new King(4,0, true));//dodanie krula

            theBoard.Add(new Queen(3,0,true));//dodanie królowej



            //dodanie czarnych figur

            for (int i = 0; i < 8; i++)// dodanie czarnych pawn 
            {
                theBoard.Add(new Pawn(i, 6, false));
            }
            theBoard.Add(new Rook(0, 7, false));//dodanie białych wież
            theBoard.Add(new Rook(7, 7, false));

            theBoard.Add(new Bishop(2, 7, false));// dodanie goniców
            theBoard.Add(new Bishop(5, 7, false));

            theBoard.Add(new Knight(1, 7, false));//dodanie skoczka
            theBoard.Add(new Knight(6, 7, false));

            theBoard.Add(new King(4, 7, false));//dodanie krula

            theBoard.Add(new Queen(3, 7, false));//dodanie królowej


        }//ustawienie figur
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
                
        }//sprawdzanie na którym polu jest jaka figura

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
        }// sprawdzanie czy figura jest biała czy czarna

        
        



    }
}
