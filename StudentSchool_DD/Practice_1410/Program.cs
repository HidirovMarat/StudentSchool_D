namespace Practice_1410
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static string FooBar(int num)
        {
            if ((num % 3 == 0) && (num % 5 == 0))
                return "foobar";
            if (num % 5 == 0)
                return "bar";
            if (num % 3 == 0)
                return "foo";
            return ""
        }
    }
}