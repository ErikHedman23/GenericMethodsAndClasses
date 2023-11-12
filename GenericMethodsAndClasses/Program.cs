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
        }
    }
}