using System;
class HelloWorld {
  static void Main() {
    
string playerName = "";
int playerScore = 0;
int cpuScore = 0;
string playerChoice = " ";
string cpuChoice = " ";
Random rnd = new Random();
int cpuRand = rnd.Next(1,3);

  Console.WriteLine("CPU: What is your name...? (Type a name then press Enter).\n");
  playerName = Console.ReadLine();
  Console.WriteLine("CPU: so your " + playerName + " huh...");
  Console.WriteLine("CPU: would you be interested in a legendary battle of Rock ,Paper , Scissors?");
  string gameChoice = Console.ReadLine().ToLower();

  if (gameChoice == "yes")
  {
    Console.WriteLine("CPU: Ok then... prepare yourself!");
    Console.WriteLine("Would you like to choose rock, paper, or scissors? (Type one of these options then press enter).");
  }
  else if (gameChoice == "maybe")
  {
    Console.WriteLine("CPU: Make up your mind then return...");
  }
  else
  {
    Console.WriteLine("CPU: Thats what i thought... Come back when you'd like to take me on...");
  }
  
  playerChoice = Console.ReadLine().ToLower();


  if (cpuRand == 0)
  {
    cpuChoice = "rock";
  }
  else if (cpuRand == 1)
  {
    cpuChoice = "paper";
  }
  else if (cpuRand == 2)
  {
    cpuChoice = "scissors";
  }
  else
  {
    Console.WriteLine("Something went wrong...");
  }
  

  if (playerChoice == "rock" && cpuChoice == "rock")
  {
    Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("A draw...");
  }
  else if (playerChoice == "rock" && cpuChoice == "paper")
  {
    Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU has won...");
    cpuScore++;
  }
  else if (playerChoice == "rock" && cpuChoice == "scissor")
  {
    Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
    Console.WriteLine("You came out victorious!");
    playerScore++;
  }
  else if (playerChoice == "paper" && cpuChoice == "rock")
  {
    Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
    Console.WriteLine("You came out victorious!");
    playerScore++;
  }
  else if (playerChoice == "paper" && cpuChoice == "paper")
  {
    Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
    Console.WriteLine("A draw...");
  }
  else if (playerChoice == "paper" && cpuChoice == "scissor")
  {
    Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
    Console.WriteLine("The CPU has won...");
    cpuScore++;
  }
  else if (playerChoice == "scissor" && cpuChoice == "rock")
  {
    Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
    Console.WriteLine("The CPU has won...");
    cpuScore++;
  }
  else if (playerChoice == "scissor" && cpuChoice == "paper")
  {
    Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
    Console.WriteLine("You came out victorious!");
    playerScore++;
  }
  else if (playerChoice == "scissor" && cpuChoice == "scissor")
  {
    Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
    Console.WriteLine("A draw...");
  }


  while (cpuScore != 3 || playerScore != 3)
  {
    Console.WriteLine("Would you like to choose rock, paper, or scissors? (Type one of these options then press enter).");
  }
 
 

  }
}