using System;

namespace Lab4_2
{
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
            SetID(_ID);
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
            return $"\nID: {ID}:\nName: {Name}:\nDescription: {Description}:\nPrice: {Price}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {//create several instancces of MenuItem.

          //Print out the details of each one using Writeline and passing the object.


            //then can try createing a MenuItem using a default constructor and notice the error. 
            //it is not in the sheet. but i think he said put a statement at the top with notes from the error.
            //but comment out the error lines.
           
        }
    }
}
