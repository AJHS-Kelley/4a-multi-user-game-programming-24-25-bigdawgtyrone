using System;
class HelloWorld {
  static void Main() {
    
string playerName = "";
int playerScore = 0;
int cpuScore = 0;
string playerChoice = " ";
string cpuChoice = " ";
Random rnd = new Random();
int cpuRand = rnd.Next(0, 2);

  Console.WriteLine("CPU: What is your name...? (Type a name then press Enter).\n");
  playerName = Console.ReadLine();
  Console.WriteLine("CPU: so your " + playerName + " huh...");
  Console.WriteLine("CPU: would you be interested in a legendary battle of Rock ,Paper , Scissors?");
  string gameChoice = Console.ReadLine().ToLower();

  if (gameChoice == "yes")
  {
    Console.WriteLine("CPU: Ok then... prepare yourself!");
  }
  else if (gameChoice == "maybe")
  {
    Console.WriteLine("CPU: Make up your mind then return...");
  }
  else
  {
    Console.WriteLine("CPU: Thats what i thought... Come back when you'd like to take me on...");
  }
  
  cpuChoice = Console.ReadLine().ToLower();
 
  if (cpuRand = 0)
  {
    cpuChoice == "Rock";
  }
  else if (cpuRand = 1)
  {
    cpuChoice == "Paper";
  }
  else if (cpuRand = 2)
  {
    cpuChoice == "Scissors";
  }
  else
  {
    Console.WriteLine("Something went wrong...");
  }

  Console.WriteLine("Would you like to choose rock, paper, or scissors? (Type one of these options then press enter).");
  Console.ReadLine().ToLower();
  if (playerChoice == "rock" && cpuChoice == "rock")
  {
    Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("A draw...");
  }
  else if (playerchoice == "rock" && cpuChoice == "paper")
  {
    Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.Writeline("The CPU has won...");
  }



  

  }
}