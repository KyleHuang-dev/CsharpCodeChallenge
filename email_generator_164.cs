using System;

namespace email_generator_164
{
	class Program
	{



		public static void GreetCustomer(string name)
		{
			Console.WriteLine("Hi " + name + "!");
			Console.WriteLine("Thank you very much for shopping with us.");
			Console.WriteLine("Our shop usually keeps special offers for customers like you; " + name + ".");
			Console.WriteLine("So " + name + ", do you want to explore your offer?");
		}

		static void Main(string[] args)
		{

			GreetCustomer("Alex");
			Console.WriteLine();
			GreetCustomer("Susan");
			Console.WriteLine();
			GreetCustomer("Ken");
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}

