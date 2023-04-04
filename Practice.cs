namespace PracCSharp
{
    struct Practice
    {
        public string Name, ID;
        public void Initialize(string Name, String ID)
        {
            this.Name = Name;
            this.ID = ID;
        }

        public void Display()
        {
            Console.WriteLine("Welcome " + Name);
            Console.WriteLine("Your ID: " + ID);
        }
    }
}