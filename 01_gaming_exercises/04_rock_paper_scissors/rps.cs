using System;
class HelloWorld {
  static void Main() {
    
string playerName = "";
int playerScore = 0;
int cpuScore = 0;
string playerChoice = "";
string cpuChoice = "";

  Console.WriteLine("CPU: What is your name...? (Type a name then press Enter).\n");
  playerName = Console.ReadLine();
  Console.WriteLine("CPU: so your " + playerName + " huh...");
  Random rnd = new Random();
  while (playerScore < 5 && cpuScore < 5)
  {
    Console.WriteLine($"Your Score: {playerScore}\n CPU Score: {cpuScore}\n");

    Console.WriteLine("Please Choose rock, paper, or scissors. Type your answer then press enter.\n");

    playerChoice = Console.ReadLine().ToLower();
    if (playerChoice != "rock" && playerChoice != "scissors" && playerChoice != "paper")
    {
      playerChoice = Console.ReadLine().ToLower(); 
    }
  
  


  int cpuRand = rnd.Next(0, 3);

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
    Console.WriteLine("CPU Choice:" + cpuChoice);


    

    if (playerChoice == "rock" && cpuChoice == "rock")
    {
      Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.WriteLine("A draw...\n");
    }
    else if (playerChoice == "rock" && cpuChoice == "paper")
    {
      Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.WriteLine("The CPU has won...\n");
      cpuScore++;
    }
    else if (playerChoice == "rock" && cpuChoice == "scissor")
    {
      Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
      Console.WriteLine("You came out victorious!\n");
      playerScore++;
    }
    else if (playerChoice == "paper" && cpuChoice == "rock")
    {
      Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
      Console.WriteLine("You came out victorious!\n");
      playerScore++;
    }
    else if (playerChoice == "paper" && cpuChoice == "paper")
    {
      Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
      Console.WriteLine("A draw...\n");
    }
    else if (playerChoice == "paper" && cpuChoice == "scissor")
    {
      Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
      Console.WriteLine("The CPU has won...\n");
      cpuScore++;
    }
    else if (playerChoice == "scissor" && cpuChoice == "rock")
    {
      Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
      Console.WriteLine("The CPU has won...\n");
      cpuScore++;
    }
    else if (playerChoice == "scissor" && cpuChoice == "paper")
    {
      Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
      Console.WriteLine("You came out victorious!\n");
      playerScore++;
    }
    else if (playerChoice == "scissor" && cpuChoice == "scissor")
    {
      Console.WriteLine($"You chose {playerChoice} and the cpu chose {cpuChoice}.\n");
      Console.WriteLine("A draw...\n");
    }
  }


  
  if (playerScore > 5 && cpuScore != 5)
  {
    Console.WriteLine("You win... lucky...!\n");
  }
  else
  {
    Console.WriteLine("You lose! You stood no chance...\n");
  }
 
 

  }
}