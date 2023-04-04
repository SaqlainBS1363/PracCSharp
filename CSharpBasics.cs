namespace PracCSharp
{
    internal partial class Program
    {
        public class CSharpBasics
        {
            public string traineeID;
            public string traineeName;
            
            public CSharpBasics(string traineeID, string traineeName)
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