/*Example 2:

Input: nums = [1, 1, 1, 1]
Output: 6
Explanation: Each pair in the array are good.*/

using System;
    class Arraypairs1
{
    public static void Main()
    {
        int[] arr = { 1, 1, 1, 1 };
        int output = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j=0; j< arr.Length; j++)
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
