//Steps to compiling and running app:
//1: Open monox86 command line
//2: cd into project directory
//3: use the 'mcs App.cs' command to complile a new App.exe
//4: use the 'mono App.exe' command to run the .exe file in monox86

using System; // By initializing a 'using' directive we are stating that all instances of classes and methods will be decendant of System.

namespace Txs.Fitness 
{
	class App 
	{
		static void Main(){
			//Main method.  
			//Prompt the user for minutes exercised

			//Now System.Console.Write can just be ....
			Console.Write("Enter how many minutes you exercised: ");

			string entry = System.Console.ReadLine(); // Reads what the user types and returns it to the program until the return key is pressed.
			 // Initialized the variable entry equal to the value of the return value of the System.Console.Readline() method.


			//Add minutes exercised to the total
			//Display total minutes exercised to the screen
			Console.WriteLine("You've exercised for " + entry + " minutes!");
			//Repeat

			 int runningTotal = 0;

			            bool keepGoing = true;
			            while(keepGoing)
			            {
			                // Prompt user for minutes exercised 
			                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
			                string entry = Console.ReadLine();        

			                if(entry == "quit")
			                {
			                    keepGoing = false;
			                }
			                else
			                {
			                    // Add minutes exercised to total 
			                    int minutes = int.Parse(entry);

			                    if(minutes <= 10)
			                    {
			                        Console.WriteLine("Quick rep?");
			                    }
			                    else if(minutes <= 30)
			                    {
			                        Console.WriteLine("Watch those gains grow!");
			                    }
			                    else if(minutes <= 60)
			                    {
			                        Console.WriteLine("What a BEAST!");
			                    }
			                    else
			                    {        
			                        Console.WriteLine("ULTRAAAAAAAAAA! ");
			                    }

			                    runningTotal = runningTotal + minutes;

			                    // Display total minutes exercised to the screen 
			                    Console.WriteLine("You've entered " + runningTotal + " minutes.");
			                }
			                // Repeat until user quits
			            }

		            Console.WriteLine("See ya later! Stay hydrated!");
 
		}
	}
}