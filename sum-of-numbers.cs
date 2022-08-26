using System;
//Write a program that finds the sum of a series of numbers typed by the user. Allow the user to continue entering integers until they type the number 0, then display the sum. After printing the sum, print “Calculate another sum? [Y/N]”. If the user types Y then start calculating the sum of another sequence of numbers. If the user types N the program should exit. If the user types anything else, print the message “Calculate another sum? [Y/N]” again.

class Program {
  public static void Main (string[] args) 
  {
   
    loop();

  }

  public static void loop ()
  {
    
    int result = 0;
    
    Console.WriteLine ("Please enter number to calculate the sum.");               
    Console.WriteLine ("Enter single 0 to get the sum.");
    string enterValue = Console.ReadLine();
    int enterNum = int.TryParse(enterValue, out enterNum) ? enterNum : 0 ;
  
    if (enterNum == 0) {
      Console.WriteLine("Invalid input.");
      PlayAgain();
      return; 
    }else{
      result = enterNum;
    }
     
    while(enterNum != 0) {
      enterValue = Console.ReadLine();
      enterNum = int.TryParse(enterValue, out enterNum) ? enterNum : 0 ;
      result += enterNum;
    }

     Console.WriteLine("The answer is " + result); 
      PlayAgain();
  }

  public static void PlayAgain ()
  {
    Console.WriteLine("Calculate other sum? [Y/N]");
    char confirm = char.Parse(Console.ReadLine());
    if (confirm == 'y' || confirm == 'Y'){
      Console.Clear();
      loop();
    }
      
    else if (confirm == 'n' || confirm == 'N')
      Console.WriteLine("Good bye.");
    else PlayAgain();
  }
  
  
}