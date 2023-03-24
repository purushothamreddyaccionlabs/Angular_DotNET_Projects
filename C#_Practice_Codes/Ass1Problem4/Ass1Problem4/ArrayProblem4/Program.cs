
/*Example 1:

Input: accounts = [[1, 2, 3],[3,2,1]]
Output: 6
Explanation:
1st customer has wealth = 1 + 2 + 3 = 6
2nd customer has wealth = 3 + 2 + 1 = 6*/

using System;
using System.Runtime;

class program
{
    public static void Main()
    {
        int[,] arr = new int[,] { { 1, 2, 3 }, { 3, 2, 1 } };
        int C1 = arr[0,0] + arr[0,1] + arr[0,2];
        
        int C2 = arr[1, 0] + arr[1, 1] + arr[1, 2];
        

        if(C1 >= C2)
        {
            Console.WriteLine(C1);
        }
        else
        {
            Console.WriteLine(C2);
        }
       

    }
}