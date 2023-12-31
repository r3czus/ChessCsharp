﻿using System;
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
            SetTheMap();
            ShowBoard();
            
        }

        void SetTheMap()
        {
            for (int i = 0; i < Sizex ; i++)
            {
                for (int j = 0; j < Sizey; j++)// odpowiada za x
                {
                  
                      string value= game.CheckTheCell(j, i);
                      board[j, i] = value;

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
                    
                    if( !game.CheckTheColor(j, i))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($" {board[j, i]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write($" {board[j, i]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    

                }
                Console.WriteLine("│");
            }
           
            Console.WriteLine(" ┴───┴───┴───┴───┴───┴───┴───┴───┘");

            Console.WriteLine(game.theBoard[9].curentlyPositionX);
            Console.Write(game.theBoard[9].curentlyPositionY);
            Console.WriteLine("\n");
            Console.WriteLine(game.theBoard[9].AllowedMove());

        } // wyświtla aktualny stan gry

        

       
       
    }

}
