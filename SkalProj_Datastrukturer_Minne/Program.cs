using System;

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
                    + "\n5. Reverse a text"
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
                    case '5':
                        ReverseText();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5)");
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
            * Loop this method untill the user inputs something to exit to main menue.
            * Create a switch statement with cases '+' and '-'
            * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
            * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
            * In both cases, look at the count and capacity of the list
            * As a default case, tell them to use only + or -
            * Below you can see some inspirational code to begin working.
           */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

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


            List<string> theList = new();
            do
            {
                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                char nav = input[0];
                if (nav != '+' && nav != '-')
                    break;

                // ToDo: Fixa acceptabel tom sträng
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

                Console.WriteLine($"Listans storlek: {theList.Count}");
                Console.WriteLine($"Underliggande arrays kapacitet: {theList.Capacity}");
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

            Queue<string> customersQueue = new();
            do
            {
                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                char nav = input[0];
                if (nav != '+' && nav != '-')
                    break;

                switch (nav)
                {
                    case '+':
                        // ToDo: Fixa acceptabel tom sträng
                        string value = input.Substring(1);
                        customersQueue.Enqueue(value);
                        break;
                    case '-':
                        // ToDo: Fixa exception om att ​ta​​ bort ​​element ur​​ kö​​ (​dequeue)​ när kön är tomt.
                        customersQueue.Dequeue();
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Nummer av kunder i ICA-kön: {customersQueue.Count}");
                Console.WriteLine($"Kunder i ICA-kön: {String.Join(",", customersQueue)}");
            } while (true);

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

            /*
             * 1.​​​​​​​​​​​​​​​​Simulera ännu ​​en ​​gång ICA-kön​​på​​papper.​​Denna ​​gång​​ med ​​en ​​​stack​.​
             * Varför ​​är ​​det inte​​ så​​ smart​​ att ​​använda​​ en​​​ stack​​​ i​​ det ​​här​​ fallet?
             * Eftersom det inte är rättvist.
             */

            Stack<string> inputStack = new();

            do
            {
                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                char nav = input[0];
                if (nav != '+' && nav != '-')
                    break;

                switch (nav)
                {
                    case '+':
                        // ToDo: Fixa acceptabel tom sträng
                        string value = input.Substring(1, 1);
                        inputStack.Push(value);
                        break;
                    case '-':
                        // ToDo: Fixa exception om att ​ta​​ bort ​​element ur​​ kö​​ (​dequeue)​ när kön är tomt.
                        inputStack.Pop();
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Nummer av elementer i stacken: {inputStack.Count}");
                Console.WriteLine($"Elementer i stacken: {String.Join(",", inputStack)}");
            } while (true);



        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Stack<char> inputStack = new();
            char[] openings = new char[] { '(', '[', '{', '<' };
            char[] closings = new char[] { ')', ']', '}', '>' };
            bool itIsValid = true;

            string? input = Console.ReadLine();
            ArgumentNullException.ThrowIfNull(input);

            foreach (char character in input.ToCharArray())
            {
                int relevantCharIndex = -1;
                bool? isItOpening = null;

                relevantCharIndex = Array.IndexOf(openings, character);

                if (relevantCharIndex != -1)
                {
                    isItOpening = true;
                }
                else
                {
                    relevantCharIndex = Array.IndexOf(closings, character);
                    if (relevantCharIndex != -1)
                        isItOpening = false;
                }

                if (isItOpening is not null)
                {
                    if (isItOpening.Value) inputStack.Push(character);
                    else
                    {
                        if (inputStack.Count == 0)
                        {
                            itIsValid = false;
                            break;
                        }
                        char lastRelevantChar = inputStack.Pop();

                        if (openings[relevantCharIndex] != lastRelevantChar)
                        {
                            itIsValid = false;
                            break;
                        }

                    }
                }
            }

            if (inputStack.Count != 0)
                itIsValid = false;


            Console.WriteLine(itIsValid ? "Valid" : "Invalid");
        }


        /// <summary>
        /// Reverses a text with the datastructure Stack
        /// </summary>
        static void ReverseText()
        {
            Stack<char> inputStack = new();
            string result = "";

            string? input = Console.ReadLine();
            ArgumentNullException.ThrowIfNull(input);

            foreach (char character in input.ToCharArray())
                inputStack.Push(character);

            foreach (char element in inputStack)
                result += element;

            GC.Collect();

            Console.WriteLine($"Reversed text: {result}");
        }

    }
}

