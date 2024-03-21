using System;

namespace Point
{
    struct Point
    {
        public int X;  
        public int Y;


        public int get_X() 
        { 

            return this.X; 
        
        }
        public int get_Y()
        {

            return this.Y;

        }   
        public void set_X(int x)
        {
            this.X = x;
        }
        public void set_Y(int y)
        { 
            this.Y = y;
        }
        

    }
    class program
    {
        static void Main(string[] args)
        {

            Point p = new Point();
            Console.WriteLine( p.get_X());
            Console.WriteLine( p.get_Y());
            p.set_X(44);
            p.set_Y(10);
            //  Console.WriteLine(p.get_X());
            // Console.WriteLine(p.get_Y());
            Point[] points = new Point[5];

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("x: ");
                points[i].set_X (int.Parse(Console.ReadLine()));

                Console.WriteLine("y: ");
              points[i].set_Y(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("x: " + points[i].get_X());
                Console.WriteLine("y: " + points[i].get_Y());
            }

            points[4].set_Y(20);


        }



    }



}
 
