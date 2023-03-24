/*Given a string, remove the vowels from the string and print the string without vowels. 

Examples: 

Input: welcome to geeksforgeeks
Output : wlcm t gksfrgks

Input : what is your name ?
Output : wht s yr nm ?*/

using System;
using System.ComponentModel;

class program
{
    public static void Main()
    {
        Console.WriteLine("please enter input");
        string name = Console.ReadLine().ToLower();
        string output = null;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        foreach(char i in name)
        {
            switch(i)
            {
                case'a':
                    break;
                case 'e':
                    break;
                case 'i':
                    break;
                case 'o':
                    break;
                case 'u':
                    break;
                default:
                    output = output + i;
                    break;

            }
        }
        
        Console.WriteLine("Your output without vowels = {0}",output);

    }
}