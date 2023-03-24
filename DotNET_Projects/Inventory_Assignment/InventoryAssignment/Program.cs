using System;
using System.ComponentModel;

class program
{
    public static void Main()
    {
        Console.WriteLine("Please select items \n E- Electronics, G - Groceries");
        string userInput = (Console.ReadLine()).ToUpper();

        Electronics obj1 = new Electronics();
        Groceriess obj = new Groceriess();

        if (userInput == "E")
        {
            obj1.elecronics();
        }
        else if(userInput == "G")
        {
            obj.groceries();
        }
        else
        {
            Console.WriteLine("Your input is {0} Invalid", userInput);
            Main();
        }




    }
}