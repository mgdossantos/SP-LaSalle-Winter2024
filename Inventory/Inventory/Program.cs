using System;

class Program
{
    static void Main(string[] args)
    {
        int op,quantity;
        int laptop = 0, mouse = 0, printer = 0;
        string type;
        do
        {
            Console.WriteLine("Inventory System");
            Console.WriteLine("1 - Add Item");
            Console.WriteLine("2 - Remove Item");
            Console.WriteLine("3 - Update Item");
            Console.WriteLine("4 - Display Inventory");
            Console.WriteLine("5 - Exit");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write(" Enter the name of the item to add: ");
                    type = Console.ReadLine();
                    Console.Write(" Enter the quantity of " + type + " : ");
                    quantity = int.Parse(Console.ReadLine());
                    if (type.ToUpper() == "LAPTOP")
                        laptop = laptop + quantity;
                    else
                    {
                        if (type.ToUpper() == "MOUSE")
                            mouse = mouse + quantity;
                        else
                        {
                            if (type.ToUpper() == "PRINTER")
                                printer = printer + quantity;
                            else
                            {
                                Console.WriteLine("Type invalid!!");
                            }
                        }
                    }
                    break;
                case 2:
                    Console.Write(" Enter the name of the item to delete: ");
                    type = Console.ReadLine();
                    Console.Write(" Enter the quantity of " + type + " : ");
                    quantity = int.Parse(Console.ReadLine());
                    if (type.ToUpper() == "LAPTOP")
                        laptop = laptop - quantity;
                    else
                    {
                        if (type.ToUpper() == "MOUSE")
                            mouse = mouse - quantity;
                        else
                        {
                            if (type.ToUpper() == "PRINTER")
                                printer = printer - quantity;
                            else
                            {
                                Console.WriteLine("Type invalid!!");
                            }
                        }
                    }
                    break;

                case 3:
                    Console.Write(" Enter the name of the item to add: ");
                    type = Console.ReadLine();
                    Console.Write(" Enter the quantity of " + type + " : ");
                    quantity = int.Parse(Console.ReadLine());
                    if (type.ToUpper() == "LAPTOP")
                        laptop = quantity;
                    else
                    {
                        if (type.ToUpper() == "MOUSE")
                            mouse = quantity;
                        else
                        {
                            if (type.ToUpper() == "PRINTER")
                                printer = quantity;
                            else
                            {
                                Console.WriteLine("Type invalid!!");
                            }
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("*** Inventory ***");
                    Console.WriteLine("Laptop: " + laptop + "\n");
                    Console.WriteLine("Mouse: " + mouse + "\n");
                    Console.WriteLine("Printer: " +printer + "\n");


                    break;
            }
        }
        while (op != 5);
        

        
    }
}
