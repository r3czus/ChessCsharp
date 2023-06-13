using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class DrawBoard
    {
       private int Sizex; 
       private int Sizey;
       private string[,] board = new string[8, 8];
       GamePlayMechanic game = new GamePlayMechanic();
       
       
       


        public DrawBoard()
        {
            Sizex = 8;
            Sizey = 8;
            PrepareyBoard();
            ShowBoard();
            

        }
        void PrepareyBoard()
        {
            for (int i = 0; i < Sizex ; i++)
            {
                for (int j = 0; j < Sizey; j++)
                {
                  
                      string value= game.CheckTheCell(i, j);
                      board[i, j] = value;

                }
            }
           
        }
        void ShowBoard()
        {
            Console.WriteLine("   A   B   C   D   E   F   G   H");
            for (int i=0; i<Sizey; i++)
            {
                
                Console.WriteLine(" ┼───┼───┼───┼───┼───┼───┼───┼───┤");

                for (int j=0; j<Sizey; j++)
                {
                    if(j==0)
                    {
                        Console.Write(i+1);
                    }
                    Console.Write("│");
                    
                    if( game.CheckTheColor(i, j))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($" {board[i, j]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write($" {board[i, j]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    

                }
                Console.WriteLine("│");
            }
           
            Console.WriteLine(" ┴───┴───┴───┴───┴───┴───┴───┴───┘");
            
            for(int k=0; k<game.theBoard.Count; k++)
            {
                Console.WriteLine( $"{k}  {game.theBoard[k].kind}  {game.theBoard[k].curentlyPositionX} {game.theBoard[k].curentlyPositionY} ");
            }

            Console.WriteLine(game.theBoard[0].AllowedMove());

        }

       
       
    }

}
