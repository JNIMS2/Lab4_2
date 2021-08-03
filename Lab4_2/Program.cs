using System;

namespace Lab4_2
{ //***the special note that Jeff wanted us to put in is below***

    //***MENU NOTE***
    //MenuItem Lolipop = new MenuItem();//says MenuItem does not contain a constructor that takes 0 arugments

    //***Rectangle NOTE***
    //1st- made 2 triangles w/sep values--the if statement printed different. because we have 2 diff instances of rectangle, with diff values. 
    //2nd- made 2 triangles, set 2nd to same value as first.--the if statement printed same. Because we made 2 rects and set them to equal the same value. but still made a new one.
    //3rd -made a triangle without NEW. set it to same value as r1. --the if statment printed same. since we didn't use NEW, this is where we are pointing to r1, right?
        //3rd cont-we didn't really make 2 instances of rect this time...technically i guess we have 2. but, r2 IS r1, right? or, is it a copy? i dont think it is a copy as far as i can tell....
        //I think this is where we only have one instance of a rectangle. 




    //***rectangle jazz***
    //create a rectangle class
    class Rectangle
    {//give it only 2 public members l and w, both int
        public int Length;
        public int Width;
    }

    //****MENU ITEM jazz***
    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;

        //make the  constructors
        //first one takes all 4 params
        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            SetID(_ID);//use equal there//no don't.
            SetName(_Name);
            SetDescription(_Description);
            SetPrice(_Price);
        }

        //second constructor takes id, name, price. but sets Descp to EMPTY.
        public MenuItem(int _ID, string _Name, decimal _Price)
        {
            SetID(_ID);
            SetName(_Name);
            SetDescription("");//I think this is it. or type EMPTY...
            SetPrice(_Price);
        }

        //should i make a print method too?

        //make setters and getters
        public int GetID()
        {
            return ID;
        }
        public void SetID(int _ID)
        {
            ID = _ID;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string _Name)
        { if (_Name == "")
            { _Name = "EMPTY"; }
            Name = _Name;//don't forget this part...almost did..yikes!
        }
        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription( string _Description)
        { 
            if (_Description == "")
            { _Description = "EMPTY"; }
            Description = _Description;
        }

        public decimal GetPrice()
        {
            return Price;
        }
        public void SetPrice( decimal _Price)
        {
            if (_Price < 0.50m)
            { _Price = 0.50m; }

            else if (_Price >10.00m)
            { _Price = 10.00m; }//i dont have to do another else statement here because i have the other 2 params, right?

            Price = _Price;
        }

        public override string ToString()
        {
            return $"\nID: {ID}\nName: {Name}\nDescription: {Description}\nPrice: {Price}";
            //with this we really don't need a print function, right? we just writeline the object..
        }

    }

    class Program
    {
        static void Main(string[] args)


        //****MENU ITEM jazz***
        {//create several instancces of MenuItem.

            MenuItem Broccoli = new MenuItem(01, "Broccoli", "Steamed Brocc", 3.00m);//was having an issue but had wrong brackets.
            MenuItem Apple = new MenuItem(02, "Apple", 2.00m);
            MenuItem Potato = new MenuItem(03, "Potato", 1.00m);
            MenuItem Chips = new MenuItem(04, "Chips", "Lays potato Chips", 0.40m);//testing my price params
            MenuItem Cake = new MenuItem(05, "Cake", "", 12.00m);//testing the max price parm


            //Print out the details of each one using Writeline and passing the object.
            Console.WriteLine(Broccoli);
            Console.WriteLine(Apple);
            Console.WriteLine(Potato);
            Console.WriteLine(Chips);
            Console.WriteLine(Broccoli.GetDescription());
            Console.WriteLine(Apple.GetPrice());
            Console.WriteLine(Cake);

            //then can try createing a MenuItem using a default constructor and notice the error. 
            //it is not in the sheet. but i think he said put a statement at the top with notes from the error.
            //but comment out the error lines.
            //MenuItem Lolipop = new MenuItem();//says MenuItem does not contain a constructor that takes 0 arugments
            Console.WriteLine();//just separating jazz



            //***rectangle jazz***
            //create 2 instances of Rect, r1 and r2 diff values

            Console.WriteLine("Triangle Jazz");//just for when running. i know not part of the instruction...
            Rectangle r1 = new Rectangle() { Length = 10, Width = 20 };//this is the long/dumb way
         // Rectangle r2 = new Rectangle() { Length = 50, Width = 15 };


            //change code so to make a new rect, we r2=r1;
            Rectangle r2 = r1;


            //change code to make r1=r2. 
            //r1 = r2;
            //write an if statement to see if same/diff
            if (r1 == r2)
            {
                Console.WriteLine("Same");
            }
            else  //(r1 != r2) had that with an else/if ...then saw the instructions....
            {
                Console.WriteLine("Different");
            }
            //1st run. they are different...duh.
            //2nd run. they are the same...also duh. 
            //3rd run. they are the same again..yep.
       




        }

       
    }
    
}

