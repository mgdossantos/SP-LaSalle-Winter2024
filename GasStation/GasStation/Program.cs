using System;

class Program
{
    static void Main(String[] args)
    {
        string type="";
        
        double liters,discount=0,ammountToPay=0;

        Console.WriteLine("Type: ");
        type = (Console.ReadLine());
        Console.WriteLine("Liters: ");
        liters=double.Parse(Console.ReadLine());

        if (type.ToLower()=="diesel" || type.ToLower()=="d")
        {
            if (liters <0)
            {
                Console.WriteLine("Invalid amount of liters");
               
            }
            else
            {
                if(liters > 25)
                {
                    discount = 0.05 * (liters * 2);
                    ammountToPay = (liters * 2) - discount;
                    

                }
                else
                {
                    discount = 0.075 * (liters * 2);
                    ammountToPay = (liters * 2) - discount;
                }
                Console.WriteLine("Amount to pay= " + ammountToPay + " CAD");
            }
        }

        else
        {
            if(type.ToLower() == "gasoline" || type.ToLower() == "g")
            {
                if (liters <0)
                {
                    Console.WriteLine("Invalid amount of liters");
                    
                }
                else
                {
                    if (liters > 25)
                    {
                        discount = 0.07 * (liters * 3);
                        ammountToPay = (liters * 3) - discount;
                        

                    }
                    else
                    {
                        discount = 0.09 * (liters * 3);
                        ammountToPay = (liters * 3) - discount;
                    }
                    Console.WriteLine("Amount to pay= " + ammountToPay + " CAD");
                }


            }

            else
            {
                Console.WriteLine("invalid type of fuel");
            }
        }
  
    }

}
