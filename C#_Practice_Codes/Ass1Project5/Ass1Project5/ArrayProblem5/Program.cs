/*Example 2:

Input: accounts = [[1, 5],[7,3],[3,5]]
Output: 10
Explanation:
1st customer has wealth = 6
2nd customer has wealth = 10 
3rd customer has wealth = 8
The 2nd customer is the richest with a wealth of 10.*/
using System;
class program
{
    public static void Main()
    {
        int[,] arr = new int[,] { { 1, 5 }, { 7, 3 }, { 3, 5 } };
        int a = 0;
        int b = 0;
        int c = 0;
        string abc = "";
        for(int i = 0; i < arr.Length; i++)
        {
            
            for(int j = 0;j< arr.GetLength(i); j++)
            {
                a = a + arr[i,j];
            }
            
            
        }
        Console.WriteLine(a);
        
    }
}