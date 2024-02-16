namespace IntDeclarations
{
     class Program
    {
        static void Main(string[] args)
        {
            int num1;
            num1 = 13;
            int num2 = 23;
            int sum = num1 + num2;
            // declaring multiple variables at once 
            int num3, num4, num5;
            num3 = sum + 13;
            num4 = num3 - num1;
            num5 = num4 + num4;
            Console.WriteLine(num1 + sum);
            Console.WriteLine("The sum of our two integers : " +  num1 + " and " + num2 + ", is : " +  (num1 + num2));
            Console.WriteLine("The declared variable num3  is : " + num3 + ", which was the sume of num1 and num2 + 13");
            Console.WriteLine("The declared variable num4 is : " + num4 + ", which was num3's value - num 1");
            Console.WriteLine("The declared variable num5 is : " + num5 + ", which was num4's value doubled");

            double d1 = 3.1415;
            double d2 = 5.1;
            Console.WriteLine("d1/d2 is " + d1 / d2);

            // for floats - per sure to add the f at the end of string (type defaults to double .. tricky with longer decimals)
            float f1 = 3.1415f;
            float f2 = 5.1f;
            Console.WriteLine("A less efficient but more efficient float value is : " + f1 / f2);
        }
    }
}
