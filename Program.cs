// Converting to a data type.
using System;
using System.Text;
namespace Converts
{
	class Converts
	{
		public static void Main(string[] args)
		{
			string buff;
			int age;
			
			Console.Write("Enter your age: ");
			buff = Console.ReadLine();
			
			try 
			{
				age = Convert.ToInt32(buff); //The conversion method being used in here, ToInt32, has the possibility of throwing three exceptions if bad information is entered.
				
				if (age < 21 ) 
				Console.WriteLine("You are under 21.");
				else
				Console.Write("You are 21 or older.");				
			} 
			catch (ArgumentException)
			{
				Console.WriteLine("No value was entered... (equal to null)");
			}
			catch( OverflowException )
			{
				Console.WriteLine("You entered a number that is too big or too small.");
			}
			catch( FormatException )
			{
				Console.WriteLine("You didn’t enter a valid number.");
			}
			catch( Exception e )
			{
				Console.WriteLine("Something went wrong with the conversion.");
				throw(e);
			}
			
			//If an exception is not thrown, a message is displayed based on whether the age is less than 21.
			Console.ReadKey(true); //pause.
		}
	}
}

//This sets up the foundation for you to be able to get information from the end user, convert
//it to a more usable format, and verify the information to make sure it is valid.