using System;
using System.Linq;
using System.Collections;




class HelloWorld {
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
  double[] GPA = {1.8D, 2.4D, 6.3D, 3.8D};

  // Print Array Contents -- All Elements on Single Line
  Console.WriteLine("The elements of each barray are:\n");
  Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen.




  } // DON'T DELETEEEEE (3 spaces)!!!!
}