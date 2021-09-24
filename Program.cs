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
  
                //This block is my first if block it tells the console what to  do if the user types Blue
                if (userValue == "Blue")
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
   
                  else  if (userValue == "black")
                    {
                        message = "Black is the colour of a blood sucking crow, and it is a color most people don't know";

                        //This changes the colour to blue when they input the colour blue
                        Console.ForegroundColor = ConsoleColor.Black;

                    }

                    //once again this says that if they inputed the value yellow then change the message and colour to yellow
                    else if (userValue == "white")
                    {
                        //This changes the message to yellow's message
                        message = "The color of purity and innocence white is a true balance of all colors";
                        //This changes the colour to yellow 
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    //This says that if the value is purple, so if they entered purple than set the colour and words to purple's 
                    else if (userValue == "purple")
                    {
                        //This sets the message to the purple one 
                        message = "Purple is like a purple sunset you only see once in a blue moon";
                        //And this changes the colour of the text so that it is magenta 
                        Console.ForegroundColor = ConsoleColor.Magenta;

                    }

                    //this says that if the user enters green then you can change the settings below acrordingly
                    else if (userValue == "orange")
                    {
                        //Changes the message to the colour green 
                        message = "The colour of enthusiasm and emotion orange exudes warmth and joy";
                        //this changes the colour to green
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                    }

                    //This says that if anyone except then accepted values is inputed than display this 
                    else
                    {
                        //This says to write that they entered the incorect value and to show what they inputed in the place of the {0} 
                        Console.WriteLine("You entered {0}, and that was not a valid anwser try again and make sure its all lowercase.", userValue);

                    }

                    //This tells it to write out the message which was changed above according to what the message was changed to above and in the proper colour
                    Console.WriteLine(message);
                    //This says to read anything that has been written out which in this case is the message about what colour they chose 
                    Console.ReadLine();

                    Console.ReadLine();


               


            }   
        }while (man == true); 
        }
    }
}
