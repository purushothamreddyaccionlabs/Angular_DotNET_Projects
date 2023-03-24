/*Example 1:

Input: s = "is2 sentence4 This1 a3"
Output: "This is a sentence"
Explanation: Sort the words in s to their original positions "This1 is2 a3 sentence4", then remove the numbers.
Example 2:*/
using System;
class program
{
    public static void Main()
    {
        string  s = "is2 sentence4 This1 a3";
        string IN = null;
        
        foreach(var i in s.Split(' '))
        {
            int lastchar = i.Length;
            
            IN = IN + lastchar;

           
        }
        Console.WriteLine(IN);
        string a = s.Substring(0,3);
        Console.WriteLine(a);

    }
}