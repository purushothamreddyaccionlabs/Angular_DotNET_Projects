using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter input1");
        /*aA*/
        string Input = Console.ReadLine();
        /*aAAAbbb*/
        Console.WriteLine("Please enter input2");
        string Input2 = Console.ReadLine();

        int InputLength = Input.Length;
        int Input2Length = Input2.Length;

        int count = 0;

        for (int i = 0; i < InputLength; i++)
        {
            for (int J = 0; J < Input2Length; J++)
            {
                if (Input[i] == Input2[J])
                {
                    count++;

                }
            }
        }
        Console.WriteLine(count);
    }
}