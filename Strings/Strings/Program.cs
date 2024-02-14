using System;

class Program
{
    static void Main(string[] args)
    {
        // declare a string course name
        string name = "Marcela";

        //size
        int size;
        size = name.Length;
        Console.WriteLine(name);
        Console.WriteLine(size);

        //show the first letter,second and last
        /*Console.WriteLine(name[0]);
        Console.WriteLine(name[1]);
        Console.WriteLine(name[size-1]);*/

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(name[i]);
        }
        //create a todolist using array

        string[] todolist = {"answer the list repeat", "answer an email" };

        // use foreach
        foreach (string s in todolist)
        {
            Console.WriteLine(s);
        }


        // string converted to Upper case
        string name2 = name.ToUpper();
        // string converted to lower case
        string name3 = name.ToLower();
        Console.WriteLine(name);
        Console.WriteLine(name2);
        Console.WriteLine(name3);

        // Finding the index of character
        // which is present in string and 
        int index = name.IndexOf('a');
        Console.WriteLine(index);
        //Substring
        string name4= name.Substring(0, 5);
        Console.WriteLine(name4);




    }
}