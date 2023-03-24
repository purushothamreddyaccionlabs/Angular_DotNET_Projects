using System;

class program
{
    static void Main()
    {
        string userChoice=string.Empty;
        do
        {
            Console.WriteLine("Please enter your target");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start < userTarget)
            {
                Console.Write(start + " ");
                start += 2;
            }
            
            do
            {
                Console.WriteLine("Do you want to continue - YES or NO");
                userChoice = Console.ReadLine().ToUpper();
                if (userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Invalid choice, Please say YES or NO");
                }
            } while (userChoice != "YES" && userChoice != "NO");
        } while (userChoice == "YES");
    }
}