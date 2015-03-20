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
    class Airplane
    {
        // PRIVATE PROPERTIES +++++++++++++++++++++++++++++++++++++++++
        private bool[] seats = new bool[10];

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++
        public Airplane()
        {
            initializeArray();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++
        // Initializes the value of checkValueArray as false
        private void initializeArray()
        {
            for (int index = 0; index < seats.Length; index++)
            {
                this.seats[index] = false;
            }
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++
        // Assign a seat in the first-class section (seats 1–5).
        public void chooseFirstSeats()
        {
            int index = 0;
            while (index < 5)
            {
                if (seats[index] == false)
                {
                    this.seats[index] = true;
                    this.printSeats();
                    break;
                }
                else if (index == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Every First class seats are not available ***");
                    Console.WriteLine("Next flight leaves in 3 hours");
                    Console.WriteLine();
                }
                index++;
            }
        }

        // Assign a seat in the economy section (seats 6–10).
        public void chooseSecSeats()
        {
            int index = 5;
            string changeSeat;

            while (index < 10)
            {
                if (seats[index] == false)
                {
                    this.seats[index] = true;
                    this.printSeats();
                    break;
                }

                //When the economy section is full, ask the person about first­‐class section
                else if (index == 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Every Economy class seats are not available ***");
                    Console.Write("Do you want to reserve a first class seat? (y/n) : ");
                    changeSeat = Console.ReadLine();

                    if (changeSeat == "y")
                        chooseFirstSeats();     
                    else
                    {
                        Console.WriteLine("Next flight leaves in 3 hours");
                        Console.WriteLine();
                    }
             }
                index++;
            }
        }

        // Display seats state
        public void printSeats()
        {
            Console.WriteLine();
            Console.WriteLine("____FIRST CLASS____|____ECONOMY CLASS____");
            Console.WriteLine(" 1   2   3   4   5 | 6   7   8   9   10 ");
            Console.WriteLine("-----------------------------------------");
            for (int index = 0; index < seats.Length; index++)
            {
                if (this.seats[index] == true)
                    Console.Write(" O  ");
                else
                    Console.Write(" X  ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }
    }
}
