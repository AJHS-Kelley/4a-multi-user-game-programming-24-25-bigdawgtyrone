using System;
using System.Linq;
using System.Collections;




class Collections {
  static void Main() {
 
 /*
  In c# a collection is known as an Array.
  -- EACH ITEM IN THE ARRAY IS KNOWN AS AN ELEMENT.
  -- NUMBER OF ELEMENTS IN AN ARRAY CANNOT CHANGED.
  -- CONTENTS OF EACH ELEMENT CAN CHANGE.
  -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION.
  -- POSITION OF THE ELEMENT IS THE INDEX.
  -- FIRST ELEMENT INDEX IS 0.
 */


  // DECLARE AND DEFINING AN ARRAY
  string[] breakfastFoods = {"cheeseburger", "double cheeseburger", "triple cheeseburger", "Chicken bigmac", "Waffles"};
  int[] testScores = {70, 74, 80, 84, 90};
  double[] GPA = {1.8D, 2.4D, 6.3D, 3.8D, 0.000001};

  // Print Array Contents -- All Elements on Single Line
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen.

  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("testScores: \n" + String.Join(", ", testScores));
  Console.WriteLine(); 

  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("GPA's: \n" + String.Join(", ", GPA));
  Console.WriteLine(); 


  } // DON'T DELETEEEEE (3 spaces)!!!!
}