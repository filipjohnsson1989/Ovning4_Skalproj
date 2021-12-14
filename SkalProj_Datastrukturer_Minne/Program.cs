﻿using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

            /*
             *  2. När ​​ökar​​ listans ​​kapacitet?​​ (Alltså ​​den​​ underliggande ​​arrayens ​​storlek)
             *  Den​​ underliggande ​​arrayens ​​storlek är 4 som standart.
             *  Det ökar när det inte finns plats till ett nyt värde och arreyen har blivit full av värden.
                
             *  3. ​​​​​​​​​​​​​​​​Med​​ hur ​​mycket ​​ökar ​​kapaciteten?
             *  Det ökar det som dubbla den nuvarande kapaciteten lika 4,8,16, 32....
             *  
             *  4. Varför​​ ökar ​​inte ​​listans​​ kapacitet​​ i​​ samma​​ takt​​ som​​ element ​​läggs ​​till?
             *  Att ökar kapaciteten tar tid och jobb varje gång. Det är en snabbare som undviker att vänta varje gång ännu mindre än en mikrosekund.
             *  Det går snabbare att komma åt värden av arrayen eftersom de läggs till ett utrymme bredvid varandra i minnet.
             *  
             *  5. ​​​​​​​​​​​​​​​​Minskar ​​kapaciteten ​​när​​ element ​​tas ​​bort​​ ur​​ listan?
             *  Nej, det gör det inte. Kapaciteten minskar inte någonsin.
             *  
             *  6.​​​​​​​​​​​​​​​​När​​ är​​ det ​​då​​ fördelaktigt ​​att ​​använda ​​en​​ egendefinierad ​​​array​​​ istället ​​för​​ en​​ lista?
             *  När vi behöver ta bort element ur listan mer än att lägga till.
             *  När det är viktig att ha fri kapaciteten på minnet.
             *  När vi vet bättre att hur mycket kapaciteten behöver att öka.
             */


            List<string> theList = new List<string>();
            do
            {
                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                char nav = input[0];
                if (nav != '+' && nav != '-')
                    break;

                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Count: {theList.Count}");
                Console.WriteLine($"Capacity: {theList.Capacity}");
            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

