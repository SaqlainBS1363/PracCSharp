namespace Task1
{
    internal partial class Program
    {
        public class practiceCSharp
        {
            public string traineeID;
            public string traineeName;
            
            public practiceCSharp(string traineeID, string traineeName)
            {
                this.traineeID = traineeID;
                this.traineeName = traineeName;
            }

            public void Introduce()
            {
                Console.WriteLine("Hello " + traineeName + ", welcome to BS23");
                Console.WriteLine("Your ID is: " + traineeID);
            }
        }
    }
}