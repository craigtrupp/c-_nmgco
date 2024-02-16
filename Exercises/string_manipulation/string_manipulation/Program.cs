namespace string_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int age = 33;
            string name = "Craig";

            //1. String concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is, " + name + ", and I'm " + age + " years old");

            // 2. String concatenation
            Console.WriteLine("String Concatenation Part 2 ");
            Console.WriteLine("You can also use positional assignments!");
            Console.WriteLine("Hello my name is, {0}, and I'm {1} years old", name, age);

            // 3. String interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine("Also, variables can be added within the curly brackets if offset with a $ prior to the encapsulation of a string");
            Console.WriteLine($"Hello my name is, {name}, and I'm {age} years old!");

            // 4. Verbatim Strings
            // For instance on a file path if you use a \ type character most string readings would try to escape a character but not with verbatims : @
            Console.WriteLine(@"File Path Example : C:\drive\images\maise_dingo.jpg");
            // Results in build error with an unrecognized escape sequence!
            //Console.WriteLine("Without a verbatim's : @ would now look like. File Path Example : C:\drive\images\maise_dingo.jpg");
        }
    }
}
