using System;
using System.Security.Cryptography;

class Program
{
    static int inputHours()
    {
        Console.WriteLine("Type the hours: ");
        int h = int.Parse(Console.ReadLine());
        return h;
    }

    static int inputMinutes()
    {
        Console.WriteLine("Type the minutes: ");
        int m = int.Parse(Console.ReadLine());
        return m;
    }

    static string conversionHours(int h, int m)
    {
        int hFinal=h, mFinal=m;

        if (h > 12)
        {
            hFinal = h - 12;
            return (hFinal + ":" + mFinal + "P.M.");
        }
        else
        {
            return (hFinal + ":" + mFinal + "A.M.");
        }
       
        
    }

    static void outPutHours(string final)
    {
        Console.WriteLine(final);
    }

    static void Main(string[] args)
    {
        //int hours= inputHours();
        //int minutes= inputMinutes();
        //string conversion = conversionHours(hours, minutes);
        //outPutHours(conversion);

        int hours, minutes,op=0;
        string conversion;

        while (op != -1)
        {
            hours = inputHours();
            minutes = inputMinutes();
            conversion = conversionHours(hours, minutes);
            outPutHours(conversion);

            Console.WriteLine("Type -1 to finish");
            op=int.Parse(Console.ReadLine());   
        }
    }
}