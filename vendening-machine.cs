/**
Correct the following program that simulates a vending machine. The program prompts the user to select an item to purchase. If they made a valid selection, it prompts them to deposit change into the machine until the remaining balance is 0. The following is a candidate solution that works for some inputs. However, it fails in certain situations. Correct the program and propose your solution.
*/
using System;

class Program {
static int TakeValidIntInput()
{
	int n;
	while (!int.TryParse(Console.ReadLine(), out n))
	{
		Console.WriteLine("Incorrect input! Please try again:");
	}
	return n;
}


  
//


  
static void Main(string[] args)
{
	int choice;
	char c;
	do
	{
		Console.Clear();
		Console.WriteLine("Select an item from the following:\n");
		Console.WriteLine("Select 1 to purchase a Can Coke for $1.75");
		Console.WriteLine("Select 2 to purchase a Juice pack for $2.35");
		Console.WriteLine("Select 3 to purchase a Water bottle for $1.25");
		Console.WriteLine("Select 4 for the exit.");

		choice = TakeValidIntInput();
		if (choice == 4) break;

		switch(choice)
		{
			case 1:
				if (PayAmount(1.75) == 1)
					Console.WriteLine("You have successfully paid for the Can Coke. Thank you.");
				else
					Console.WriteLine("You have canceled the purchase!");
				break;
			case 2:
				if(PayAmount(2.35) == 1)
					Console.WriteLine("You have successfully paid for the Juice pack. Thank you.");
				else
					Console.WriteLine("You have canceled the purchase!");
				break;
			case 3:
				if(PayAmount(1.25) == 1)
					Console.WriteLine("You have successfully paid for the Water bottle. Thank you.");
				else
					Console.WriteLine("You have canceled the purchase!");
				break;
			default:
          Console.WriteLine("Invalid input");
				break;
		}
		Console.Write("\nDo you want to buy again? (y/n): ");
		c = char.Parse(Console.ReadLine());
    
    if (c=='N'|| c=='n'){
      Console.WriteLine("Have a good day!");
      break;
    }
    
	} while (c == 'y' || c == 'Y');
}
}