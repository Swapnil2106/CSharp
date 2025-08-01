namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. This is how you print Hello World in C# on the console.
            Console.WriteLine("Hello, World!");

            //2. This is you add a single line comment in C#.
            // This is a single line comment in C#

            //3. This is how you add a multi-line comment in C#.
            /*
             * This is a multi-line comment in C#
             * It can span multiple lines
             */

            //4. This is how you declare a variable in C#.
            //Refer the Variables class for more details.
            var variables = new Classes.Variables();
            variables.PrintVariables();

            //5. This is how you use a string in C#.
            //Refer the StringClass class for more details.
            var stringClass = new Classes.StringClass();
            stringClass.PrintStringMethods();
        }
    }
}
