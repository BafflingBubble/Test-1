using System;
using System.Linq.Expressions;

namespace ColourPicker_3._0
{
    class Program
    {
        static void Main(string[] args)
        {bool man = true
        {do

            {
                //This block of code is to tell the console to say to pick a colour and how to identify an input
                // Console color changes the colour of the text
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pick/Type A Colour, Red, Blue, Yellow, Green");
                string userValue = Console.ReadLine();

                Console.WriteLine("Aiden Sucks");
                Console.WriteLine("Kyle sucks, alot");


                //This block is my first if block it tells the console what to  do if the user types Blue
                if (userValue == "Blue")       //eat my poo you big ape
                {
                   
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Fun Fact The color blue is the least common color in the foods we eat.");
                    
                }
                //This block is my second if block it tells the console what to  do if the user types Red
                else if (userValue == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fun Fact Red doesn't make Bulls angry");
                    
                }
                //This block is my third if block it tells the console what to  do if the user types Yellow
                else if (userValue == "Yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fun Fact It is considered one of the 3 primary colors");
                    
                }
                //This block is my fourth if block it tells the console what to  do if the user types Green
                else if (userValue == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Fun Fact Green was George Washington's favorite color");
                    
                }
                //This block is my catch all block and tells the console what to do in the user enters an invalid input
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sorry you entered something that’s not an option or spelled something wrong (make sure the first letter is capitalized");
                   
                }
                Console.ReadLine();


               


            }   
        }while (man == true); 
        }
    }
}
