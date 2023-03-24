/*Given a valid (IPv4) Internet Protocol address S, the task is to find the defanged version of that IP address.
Defanged Version of IP Address: is in which every period “.” is replaced by “[.]”. 

Examples:

Input: S = “1.1.1.1” 
Output: 1[.]1[.]1[.]1

Input: S = “255.100.50.0” 
Output: 255[.]100[.]50[.]0 */
using System;
class program
{
    public static void Main()
    {
        Console.WriteLine("Please give IP address");
        string UserInput = Console.ReadLine();
        string output = null;
        foreach(char i in UserInput)
        {
            switch (i)
            {
                case '.':
                    output = output + "[.]";
                    break;
                default:
                    output = output + i;
                    break;
            }
        }
        Console.WriteLine("Your output is {0}",output);
    }
}