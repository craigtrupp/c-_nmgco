using System.Security.Cryptography.X509Certificates;

namespace ex1_parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be an int 
            double stringToFloat = double.Parse(stringForFloat);
            int stringToInt = int.Parse(stringForInt);
            long stringToLong = long.Parse(stringForInt);
            static void OutPutType(string originalValue, int x = 0)
            {
                Console.WriteLine("Our initial value : {0} was a {1}", originalValue, originalValue.GetType().Name);
                Console.WriteLine("It's value after parsing : {0} which is now a {1}", x, x.GetType().Name);
            }
            OutPutType(stringForInt, stringToInt);
            Console.WriteLine("Unfortunately a default argument must have the same type passed");
            Console.WriteLine("For our float check, the value in the string was : {0} which indeed was a {1}", stringForFloat, stringForFloat.GetType().Name);
            Console.WriteLine("Following chaning to a double, the value is {0} and it's type is {1}", stringToFloat, stringToFloat.GetType().Name);
        }

    }
}
