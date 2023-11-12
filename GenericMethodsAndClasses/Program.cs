namespace GenericMethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);

            Console.WriteLine(intStack.Get(1));


            Elems<string> elems1 = new Elems<string>();
            elems1.Add("John", "Tamara", "David");
            elems1.Show();

            Console.WriteLine();

            Elems<int> elems2 = new Elems<int>();
            elems2.Add(5, 14, 13);
            elems2.Show();
            
            int a = 4, b = 9;
            GenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine(a + " " + b);

            string x = "Hello";
            string y = "World";
            GenericMethods.Swap<string>(ref x, ref y);
            Console.WriteLine(x + " " + y);
        }
    }
}