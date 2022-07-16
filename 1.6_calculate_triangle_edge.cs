using System;
/*
*
*Fix the errors in the following code*
*/

class Program
	{
		static void Main(string[] args)
		{
			float a, b, gamma;
			Console.WriteLine("Enter the length side a: ");
			a = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the length of side b: ");
			b = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the angle gamma: ");
			gamma = float.Parse(Console.ReadLine());

			Console.WriteLine("The length of side c is " + CalcTriangleEdge(a, b, DegreesToRadians(gamma)));
			//return "0";
		}

		static float CalcTriangleEdge(float a, float b, float gamma)
		{

			return (float)Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(gamma)); ;
		}
  
     static float DegreesToRadians(float degrees)
		{
			const float PI = 3.14159f;
			return degrees * PI / 180.0f;
		}
		


	}