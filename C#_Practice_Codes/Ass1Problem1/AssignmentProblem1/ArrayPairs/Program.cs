using System;

/*Example 1:

Input: nums = [1, 2, 3, 1, 1, 3]
Output: 4
Explanation: There are 4 good pairs(0,3), (0, 4), (3, 4), (2, 5) 0 - indexed.*/

class program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 1, 1, 3 };
        int finalOutput = 0;
        for(int i = 0; i< arr.Length; i++)
        {
            for(int j= 0; j< arr.Length; j++)
            {
                if (arr[i] == arr[j] && i<j)
                {
                    finalOutput++;
                }
            }
        }
        Console.WriteLine(finalOutput);
    }
}