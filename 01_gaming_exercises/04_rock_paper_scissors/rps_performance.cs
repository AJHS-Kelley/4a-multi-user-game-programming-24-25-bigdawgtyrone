using System;
class HelloWorld {
  static void Main() {
    
int numDraws = 0;    
int playerScore = 0;
int cpuScore = 0;
string playerChoice = " ";
string cpuChoice = " ";
int loopCount = 0;
string loopReqs = "";
Random rnd = new Random();
int cpuRand = rnd.Next(1,3);



  
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
    numDraws++;
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
    numDraws++;
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
    numDraws++;
  }


Console.Writeline("How many loops doy ou need?\nType an INTEGER then press ENTER.\n");
loopReqs = Convert.ToInt32(Console.ReadLine());

while (loopCount < loopReqs)

if (playerRand == 0)
  {
    playerChoice = "rock";
  }
  else if (playerRand == 1)
  {
    playerChoice = "paper";
  }
  else if (playerRand == 2)
  {
    playerChoice = "scissors";
  }
  else
  {
    Console.WriteLine("Something went wrong...");


// while (playerScore <5 && cpuScore < 5);

if (playerScore > cpuScore)
{
  Console.WriteLine("Wow you actually managed to win... now do it again...");
}
else
{
  Console.WriteLine("YOU LOSE!!");
}





  
 
 

  }
}}