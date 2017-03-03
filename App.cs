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
			//Repeat
		}
	}
}