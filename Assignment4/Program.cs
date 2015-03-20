/********************************************************
 * Hyoim Shin (300802252)
 * March 16, 2015
 * Assignment4-2 : Array Practice
 * Revision History : 
 * 
 * ******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyoimShin_Assignment4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            Random rnd = new Random();
            Airplane air = new Airplane();

            while (selection != 3)
            {
                Console.WriteLine("++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                +");
                Console.WriteLine("+    1. For first class          +");
                Console.WriteLine("+    2. For economy              +");
                Console.WriteLine("+    3. Exit                     +");
                Console.WriteLine("+                                +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++");
                Console.Write("Please make your selection: ");
                
                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        air.chooseFirstSeats();
                        break;
                    case 2:
                        air.chooseSecSeats();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorrect entry. Please try again....\n");
                        break;
                }
            }
        }   
    }
}
