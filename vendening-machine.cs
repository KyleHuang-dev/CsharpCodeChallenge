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


  
static int PayAmount(double total)
{
	int selection;
	double amount = 0;
	while (total > 0.001)
	{
		Console.Clear();
		Console.WriteLine("Your current due is : $" + total);
		Console.WriteLine("Please enter one coin at a time:\n");
		Console.WriteLine("Select 1 to pay $1.00");
		Console.WriteLine("Select 2 to pay $0.50");
		Console.WriteLine("Select 3 to pay $0.25");
		Console.WriteLine("Select 4 to pay $0.10");
		Console.WriteLine("Select 5 to pay $0.05");
		Console.WriteLine("Select 6 to pay $0.01");
		Console.WriteLine("Select 0 for returning to the Main Menu.");
		selection = TakeValidIntInput();
    
		if (selection == 0) return 0;
		else if (selection == 1) amount = 1.0;
		else if (selection == 2) amount = 0.5;
		else if (selection == 3) amount = 0.25;
		else if (selection == 4) amount = 0.10;
		else if (selection == 5) amount = 0.05;
		else if (selection == 6) amount = 0.01;
		if(total < amount)
		{
			Console.WriteLine("The system does not support overpayment! \nPlease select a lower amount.");
			Console.WriteLine("Press any key to continue...");
			Console.Read();
		}
		else
		{
			total = Math.Round(total - amount, 2);
		}
	}
	return 1;
}


  
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