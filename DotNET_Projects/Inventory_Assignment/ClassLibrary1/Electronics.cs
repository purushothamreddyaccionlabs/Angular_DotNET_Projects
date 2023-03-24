public class Electronics
{
    public void elecronics()
    {
        Console.WriteLine("You are in Elecronoics section\nPlease select M-Mobiles,T-Tablets,L-Laptops");
        string usermtl = (Console.ReadLine()).ToUpper();

        if(usermtl == "M")
        {
            Mobiles();
        }
        else if(usermtl == "T")
        {
            Tablets();
        }
        else if(usermtl == "L")
        {
            Laptops();
        }
        else
        {
           
            Console.WriteLine("Your input is {0} invalid", usermtl);
            Console.WriteLine("\n");
            elecronics();
        }
    }

    public void Mobiles()
    {
        int AvilableStock = 298;
        int SoldStock = 29;
        int TotalStock = AvilableStock + SoldStock;
    Start:
        Console.WriteLine("Please Select one item to know details\nA-AvailableStock,S-SaledStock,T-totalStock,D-totalInventoryDetails");
        string userkey = (Console.ReadLine()).ToUpper();

        switch (userkey)
        {
            case "A": Console.WriteLine("Available Stock is: " + AvilableStock);
                
                break;
            case "S": Console.WriteLine("Sold Stock is: " + SoldStock);
                break;
            case "T": Console.WriteLine("Total Stock is: " + TotalStock);
                break;
            case "D": Console.WriteLine("Available Stock is: {0}\nSold Stock is: {1}\nTotal Stock is: {2}",AvilableStock, SoldStock, TotalStock);
                      
                break;
            default:
                Console.WriteLine("User input {0} invalid",userkey);
                goto Start;
        }
       
    }
    public void Tablets()
    {
        int AvilableStock = 390;
        int SoldStock = 180;
        int TotalStock = AvilableStock + SoldStock;
    Start:
        Console.WriteLine("Please Select one item to know details\nA-AvailableStock,S-SaledStock,T-totalStock,D-totalInventoryDetails");
        string userkey = (Console.ReadLine()).ToUpper();

        switch (userkey)
        {
            case "A":
                Console.WriteLine("Available Stock is: " + AvilableStock);
                break;
            case "S":
                Console.WriteLine("Sold Stock is: " + SoldStock);
                break;
            case "T":
                Console.WriteLine("Total Stock is: " + TotalStock);
                break;
            case "D":
                Console.WriteLine("Available Stock is: {0}\nSold Stock is: {1}\nTotal Stock is: {2}", AvilableStock, SoldStock, TotalStock);

                break;
            default:
                Console.WriteLine("User input {0} invalid", userkey);
                goto Start;
        }

    }
    public void Laptops()
    {
        int AvilableStock = 20;
        int SoldStock = 90;
        int TotalStock = AvilableStock + SoldStock;
    Start:
        Console.WriteLine("Please Select one item to know details\nA-AvailableStock,S-SaledStock,T-totalStock,D-totalInventoryDetails");
        string userkey = (Console.ReadLine()).ToUpper();

        switch (userkey)
        {
            case "A":
                Console.WriteLine("Available Stock is: " + AvilableStock);
                break;
            case "S":
                Console.WriteLine("Sold Stock is: " + SoldStock);
                break;
            case "T":
                Console.WriteLine("Total Stock is: " + TotalStock);
                break;
            case "D":
                Console.WriteLine("Available Stock is: {0}\nSold Stock is: {1}\nTotal Stock is: {2}", AvilableStock, SoldStock, TotalStock);

                break;
            default:
                Console.WriteLine("User input {0} invalid", userkey);
                goto Start;
        }

    }
}
