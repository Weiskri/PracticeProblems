using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {//Homework 1
            //string fullName = "Kristin K Weis";
            //string favoriteCar = "Tesla Model S";
            //string comicBook = "Wonder Woman";
            //Console.WriteLine(fullName);
            //Console.WriteLine(favoriteCar);
            //Console.WriteLine(comicBook);

            // Homework 2 (from the Expressions presentation)
            // Use the least amount of code and variables to provide these answers

            // problem 1
            //double units = 7 - 2;
            //Console.WriteLine(units);
            //// problem 2
            //units = 13 * 4;
            //Console.WriteLine(units);
            //// problem 3
            //units = 40 / 8;
            //Console.WriteLine(units);
            //// problem 4
            //units = 41 - 29;
            ////Console.WriteLine(units);
            ////// problem 5
            ////units = 47 - 30;
            ////Console.WriteLine(units);
            ////// problem 6
            ////units = 12 / 3;
            ////Console.WriteLine(units);
            ////// problem 7 
            ////units = 5.12 + 27.10;
            ////Console.WriteLine(units);

            //// problem 1
            //int unitsOfMeasure = 7 - 2;
            //Console.WriteLine(unitsOfMeasure);
            //// problem 2
            //double money = 13 * 4;
            //Console.WriteLine(money);
            //// problem 3
            //unitsOfMeasure = 40 / 8;
            //Console.WriteLine(unitsOfMeasure);
            //// problem 4
            //money = 41 - 29;
            //Console.WriteLine(money);
            //// problem 5
            //unitsOfMeasure = 47 - 30;
            //Console.WriteLine(unitsOfMeasure);
            //// problem 6
            //unitsOfMeasure = 12 / 3;
            //Console.WriteLine(unitsOfMeasure);
            //// problem 7
            //money = 5.12 + 27.10;
            //Console.WriteLine(money);

            //// for a better solution, define the variables just as values and then use console writeline to perform the equation
            //// unitsofMeasure = 15
            //// money = 10
            //// Ex: Console.WriteLine (unitsOfMeasure - money)
            //// This is different than doing the equation in the variable and then writing the variable

            // Homework 3

            // Problem 1: Muffins
            // Greeting message
            //Console.WriteLine("Hello. Please enter your name.");
            //string userInputName = Console.ReadLine();

            //// You are baking muffins!
            //Console.WriteLine("{0} is baking muffins. {0} needs seven cups of sugar in the muffin batter.", userInputName);
            //Console.WriteLine("How many cups of sugar has {0} put in the muffin batter?", userInputName);
            //string userInputSugarCupsOne = Console.ReadLine();
            //double userInputSugarCups = Convert.ToDouble(userInputSugarCupsOne);
            //// Tells the user how many more cups of sugar to put in the muffin batter. 
            //double cupsofSugarNeeded = 7 - userInputSugarCups;
            //Console.WriteLine(userInputName + " " + "needs to put" + " " + cupsofSugarNeeded+ " " + "more cups of sugar in the muffin batter.");

            //// Problem 2: Splitting the bill
            //Console.WriteLine("   ");
            ////Inputting Friend Names
            //Console.WriteLine("{0} is out with three friends. Please input {0}'s friends' names. \nWhat is the first name?", userInputName);
            //string friendNameOne = Console.ReadLine();
            //Console.WriteLine("Second name?");
            //string friendNameTwo = Console.ReadLine();
            //Console.WriteLine("And the third friend's name?");
            //string friendNameThree = Console.ReadLine();
            //// Entering the amount each person paid
            //Console.WriteLine("{0}, {1}, {2}, and {3} are eating at a restaurant.", userInputName, friendNameOne, friendNameTwo, friendNameThree);
            //Console.WriteLine("In order to determine the total bill at the restaurant, please enter the amount each person paid.");
            //Console.WriteLine("How much did {0} pay?", userInputName);
            //string personOnePaymentString = Console.ReadLine();
            //Console.WriteLine("How much did {0} pay?", friendNameOne);
            //string personTwoPaymentString = Console.ReadLine();
            //Console.WriteLine("How much did {0} pay?", friendNameTwo);
            //string personThreePaymentString = Console.ReadLine();
            //Console.WriteLine("How much did {0} pay?", friendNameThree);
            //string personFourPaymentString = Console.ReadLine();
            //// Converting these strings to double
            //double personOnePaymentDouble = Convert.ToDouble(personOnePaymentString);
            //double personTwoPaymentDouble = Convert.ToDouble(personTwoPaymentString);
            //double personThreePaymentDouble = Convert.ToDouble(personThreePaymentString);
            //double personFourPaymentDouble = Convert.ToDouble(personFourPaymentString);

            //double totalBill = personOnePaymentDouble + personTwoPaymentDouble + personThreePaymentDouble + personFourPaymentDouble;
            //Console.WriteLine("The total bill is $" + totalBill);

            // homework: create an array with a length of 25 (25 elements), populate that array with a for loop

            // create a for loop, print to the console every other element

            string[] bunnies = new string[25];
            for (int i =0; i <bunnies.Length; i++)
            {
                Console.WriteLine("Enter a breed of rabbit.");
                bunnies[i] = Console.ReadLine();

            }

            for (int i =0; i <bunnies.Length; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(bunnies[i]);
                }
            }

        





        








    

        }
    }
}
