/*Example 3:

Input: nums = [1, 2, 3]
Output: 0*/
using System;
class program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3 };
        int output = 0;
        for(int i=0; i<arr.Length; i++)
        {
            for (int j=0; j<arr.Length; j++)
            {
                if (arr[i] == arr[j] && i<j)
                {
                    output++;
                }
            }
        }
        Console.WriteLine(output);
    }
  
}