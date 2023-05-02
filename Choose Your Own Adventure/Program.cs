using System;

namespace Choose_Your_Own_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello, {name}! Welcome to our story.\n");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?\n");

            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
            string upperNoiseChoice = noiseChoice.ToUpper();

            if(upperNoiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
            }
            else if(upperNoiseChoice == "YES")
            {
                Console.WriteLine("\nYou walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                Console.WriteLine();
            }

            Console.Write("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine();
            string upperDoorChoice = doorChoice.ToUpper();

            if(upperDoorChoice == "KNOCK")
            {
                Console.WriteLine("\nA voice behind the door speaks. It says, \"Answer this riddle: \" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"\n");
                Console.WriteLine("Type your answer: ");
                string riddleAnswer = Console.ReadLine();
                string upperRiddleAnswer = riddleAnswer.ToUpper();
                
                if(upperRiddleAnswer == "NOTHING")
                {
                    Console.WriteLine("\nThe door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
                }
                else
                {
                    Console.WriteLine("\nYou answered incorrectly. The door doesn't open. THE END.");
                }
            }
            else if(upperDoorChoice == "OPEN")
            {
                Console.WriteLine("\nThe door is locked! See if one of your three keys will open it.");
                Console.Write("\nEnter a number (1-3) ");
                string keyChoice = Console.ReadLine();
                string upperKeyChoice = keyChoice.ToUpper();

                switch(keyChoice)
                {
                    case "1":
                        Console.WriteLine("\nYou choose the first key. Lucky choice! The door opens and NOTHING is there.\nStrange...\nTHE END.");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
                        break;
                }
            }
        }
    }
}
