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
            do
            {
                // Huvudmeny
                ShowMainMenu();
                GetUserInput();
            } while (true);
        }
        private static void ShowMainMenu()
        {
            UI.Clear();
            UI.AddMessage("Please navigate through the menu by inputting the number genom NumPad \n(1, 2, 3 ,4, 5, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Reverse a text"
                    + "\n0. Exit the application");
        }

        private static void GetUserInput()
        {
            var keyPressed = UI.GetKey();//Creates the Key input to be used with the switch-case below.

            var actionMeny = new Dictionary<ConsoleKey, Action>()
                {
                    {ConsoleKey.NumPad1,ExamineList },
                    {ConsoleKey.NumPad2,ExamineQueue },
                    {ConsoleKey.NumPad3,ExamineStack },
                    {ConsoleKey.NumPad4,CheckParanthesis },
                    {ConsoleKey.NumPad5,ReverseText },
                    {ConsoleKey.NumPad0,ClosePrograme },
                };

            if (actionMeny.ContainsKey(keyPressed))
                actionMeny[keyPressed]?.Invoke();

        }

        static void ClosePrograme()
        {
            UI.AddMessage("Stängs");
            Environment.Exit(0);
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

            UI.Clear();

            List<string> theList = new();
            do
            {
                UI.AddMessage("+ För att lägga till, - För att ta bort. Tomt att gå till backa till huvudmeny");

                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                if (string.IsNullOrEmpty(input))
                    break;

                char nav = input[0];

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
                UI.Clear();

                UI.AddMessage($"Listans storlek: {theList.Count}");
                UI.AddMessage($"Underliggande arrays kapacitet: {theList.Capacity}");
                UI.AddMessage($"Elementer i listen: {String.Join(",", theList)}");

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

            UI.Clear();

            Queue<string> customersQueue = new();
            do
            {
                UI.AddMessage("+ För att lägga till, - För att ta bort. Tomt att gå till backa till huvudmeny");

                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                if (string.IsNullOrEmpty(input))
                    break;

                char nav = input[0];

                switch (nav)
                {
                    case '+':
                        // ToDo: Fixa acceptabel tom sträng
                        string value = input.Substring(1);
                        customersQueue.Enqueue(value);
                        break;
                    case '-':
                        // ToDo: Fixa exception om att ​ta​​ bort ​​element ur​​ kö​​ (​dequeue)​ när kön är tomt.
                        if (customersQueue.Count > 0)
                            customersQueue.Dequeue();
                        break;
                    default:
                        break;
                }
                UI.Clear();

                UI.AddMessage($"Nummer av kunder i ICA-kön: {customersQueue.Count}");
                UI.AddMessage($"Kunder i ICA-kön: {String.Join(",", customersQueue)}");
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

            UI.Clear();

            Stack<string> inputStack = new();
            do
            {
                UI.AddMessage("+ För att lägga till, - För att ta bort. Tomt att gå till backa till huvudmeny");

                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                if (string.IsNullOrEmpty(input))
                    break;

                char nav = input[0];

                switch (nav)
                {
                    case '+':
                        // ToDo: Fixa acceptabel tom sträng
                        string value = input.Substring(1, 1);
                        inputStack.Push(value);
                        break;
                    case '-':
                        // ToDo: Fixa exception om att ​ta​​ bort ​​element ur​​ kö​​ (​dequeue)​ när kön är tomt.
                        if (inputStack.Count > 0)
                            inputStack.Pop();
                        break;
                    default:
                        break;
                }
                UI.Clear();

                UI.AddMessage($"Nummer av elementer i stacken: {inputStack.Count}");
                UI.AddMessage($"Elementer i stacken: {String.Join(",", inputStack)}");
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

            UI.Clear();
            do
            {
                bool itIsValid = true;

                UI.AddMessage("Ange en sträng för att kontrollera om parenteserna i strängen är korrekta eller felaktiga.");
                UI.AddMessage("Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };");
                UI.AddMessage("Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );");
                UI.AddMessage("Tomt att gå till backa till huvudmeny");


                string? input = Console.ReadLine();
                ArgumentNullException.ThrowIfNull(input);

                if (string.IsNullOrEmpty(input))
                    break;

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


                UI.AddMessage(itIsValid ? "Valid" : "Invalid");
            } while (true);

        }


        /// <summary>
        /// Reverses a text with the datastructure Stack
        /// </summary>
        static void ReverseText()
        {
            UI.Clear();

            UI.AddMessage("Skriv in en text för att vända texten");

            Stack<char> inputStack = new();
            string result = "";

            string? input = Console.ReadLine();
            ArgumentNullException.ThrowIfNull(input);

            foreach (char character in input.ToCharArray())
                inputStack.Push(character);

            foreach (char element in inputStack)
                result += element;

            GC.Collect();

            UI.AddMessage($"Reversed text: {result}");
            UI.GetKey();
        }

    }
}

