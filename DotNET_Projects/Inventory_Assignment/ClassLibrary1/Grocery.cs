public class Groceriess
{
    public void groceries()
    {
        Console.WriteLine("You are in groceries section\nPlease select C-carrot,H-Chilli,T-Tomato,M-Milk");
        string usermtl = (Console.ReadLine()).ToUpper();

        if (usermtl == "C")
        {
            carrot();
        }
        else if (usermtl == "H")
        {
            Chilli();
        }
        else if (usermtl == "T")
        {
            Tomato();
        }
        else if(usermtl == "M")
        {
            Milk();
        }
        else
        {

            Console.WriteLine("Your input is {0} invalid", usermtl);
            Console.WriteLine("\n");
            groceries();
        }
    }

    public void carrot()
    {
        int AvilableStock = 120;
        int SoldStock = 30;
        int TotalStock = AvilableStock + SoldStock;
    Start:
        Console.WriteLine("Please Select one item to know details\nA-AvailableStock,S-SaledStock,T-totalStock,D-totalInventoryDetails");
        string userkey = (Console.ReadLine()).ToUpper();

        switch (userkey)
        {
            case "A":
                Console.WriteLine("Available Stock is: " + AvilableStock + " kgs");

                break;
            case "S":
                Console.WriteLine("Sold Stock is: " + SoldStock + " kgs");
                break;
            case "T":
                Console.WriteLine("Total Stock is: " + TotalStock + " kgs");
                break;
            case "D":
                Console.WriteLine("Available Stock is: {0} kgs\nSold Stock is: {1} kgs\nTotal Stock is: {2} kgs", AvilableStock, SoldStock, TotalStock);

                break;
            default:
                Console.WriteLine("User input {0} invalid", userkey);
                goto Start;
        }
        
    }
    public void Chilli()
    {
        int AvilableStock = 430;
        int SoldStock = 180;
        int TotalStock = AvilableStock + SoldStock;
    Start:
        Console.WriteLine("Please Select one item to know details\nA-AvailableStock,S-SaledStock,T-totalStock,D-totalInventoryDetails");
        string userkey = (Console.ReadLine()).ToUpper();

        switch (userkey)
        {
            case "A":
                Console.WriteLine("Available Stock is: " + AvilableStock + " kgs");
                break;
            case "S":
                Console.WriteLine("Sold Stock is: " + SoldStock + " kgs");
                break;
            case "T":
                Console.WriteLine("Total Stock is: " + TotalStock + " kgs");
                break;
            case "D":
                Console.WriteLine("Available Stock is: {0} kgs\nSold Stock is: {1} kgs\nTotal Stock is: {2} kgs", AvilableStock, SoldStock, TotalStock);

                break;
            default:
                Console.WriteLine("User input {0} invalid", userkey);
                goto Start;
        }

    }
    public void Tomato()
    {
        int AvilableStock = 300;
        int SoldStock = 870;
        int TotalStock = AvilableStock + SoldStock;
    Start:
        Console.WriteLine("Please Select one item to know details\nA-AvailableStock,S-SaledStock,T-totalStock,D-totalInventoryDetails");
        string userkey = (Console.ReadLine()).ToUpper();

        switch (userkey)
        {
            case "A":
                Console.WriteLine("Available Stock is: " + AvilableStock+" kgs");
                break;
            case "S":
                Console.WriteLine("Sold Stock is: " + SoldStock + " kgs");
                break;
            case "T":
                Console.WriteLine("Total Stock is: " + TotalStock + " kgs");
                break;
            case "D":
                Console.WriteLine("Available Stock is: {0} kgs\nSold Stock is: {1} kgs\nTotal Stock is: {2} kgs", AvilableStock, SoldStock, TotalStock);

                break;
            default:
                Console.WriteLine("User input {0} invalid", userkey);
                goto Start;
        }

    }
    public void Milk()
    {
        int AvilableStock = 2000;
        int SoldStock = 870;
        int TotalStock = AvilableStock + SoldStock;
    Start:
        Console.WriteLine("Please Select one item to know details\nA-AvailableStock,S-SaledStock,T-totalStock,D-totalInventoryDetails");
        string userkey = (Console.ReadLine()).ToUpper();

        switch (userkey)
        {
            case "A":
                Console.WriteLine("Available Stock is: " + AvilableStock + "ltr");
                break;
            case "S":
                Console.WriteLine("Sold Stock is: " + SoldStock+ "ltr");
                break;
            case "T":
                Console.WriteLine("Total Stock is: " + TotalStock + "ltr");
                break;
            case "D":
                Console.WriteLine("Available Stock is: {0}ltr\nSold Stock is: {1}ltr\nTotal Stock is: {2}ltr", AvilableStock, SoldStock, TotalStock);

                break;
            default:
                Console.WriteLine("User input {0} invalid", userkey);
                goto Start;
        }

    }
}
