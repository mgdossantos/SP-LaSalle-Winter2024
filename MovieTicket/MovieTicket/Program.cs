using System;

namespace MovieTicket
{
    struct MovieTicket
    {
        //properties
        string title;
        int duration;
        double price;
        string type;
        int room;

        public MovieTicket(string t,int d)
        {
            this.title = t;
            this.duration = d;
            this.price = 0;
            this.type = "";
            this.room = 0;

        }

        public string getTitle()
        {
            return this.title;
        }

        public int getDuration()
        {
            return this.duration;
        }

        public double getPrice()
        {
            return this.price;
        }

        public string getType()
        {
            return this.type;
        }

        public int getRoom()
        {
            return this.room;
        }

        public void setType(int t)
        {            
            if (t == 1){ this.type = "Normal"; }
            if (t == 2) { this.type = "Senior"; }
            if (t == 3) { this.type = "Student"; }
        }

        public void setPrice()
        {
            if (this.type == "Normal")
            {
                this.price = 15.50;
            }

            if (this.type == "Senior")
            {
                this.price = 15.50*0.03 ;
            }

            if (this.type == "Student")
            {
                this.price = 15.50 * 0.05;
            }

            this.price = this.price + 0.15 * this.price;
        }

        public void setRoom(int r)
        {
            if (r > 0 && r < 11)
            {
                this.room = r;
            }
            else
            {
                this.room = 0;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicket ticket1 = new MovieTicket();
            Console.WriteLine("Title:"+ticket1.getTitle());
            Console.WriteLine("Duration:" + ticket1.getDuration());
            Console.WriteLine("Price:" + ticket1.getPrice());

            MovieTicket ticket2 = new MovieTicket("The Marvels",105);
            Console.WriteLine("Title:" + ticket2.getTitle());
            Console.WriteLine("Duration:" + ticket2.getDuration());
            Console.WriteLine("Price:" + ticket2.getPrice());
            Console.WriteLine("Type: "+ticket2.getType());
            Console.WriteLine("Type: " + ticket2.getRoom());

            ticket2.setType(1);
            //Console.WriteLine("Type: "+ticket2.getType());
            ticket2.setPrice();
            //Console.WriteLine("Price:" + ticket2.getPrice());
            ticket2.setRoom(1);
            Console.WriteLine("Title:" + ticket2.getTitle());
            Console.WriteLine("Duration:" + ticket2.getDuration());
            Console.WriteLine("Price:" + ticket2.getPrice());
            Console.WriteLine("Type: " + ticket2.getType());
            Console.WriteLine("Room: " + ticket2.getRoom());


        }
    }
}
    