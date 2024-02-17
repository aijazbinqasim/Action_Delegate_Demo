namespace Action_Delegate_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var add = new Action<double, int>(Add);
            // OR following
            //Action<double, int> add = Add;
            add(10.5, 10);


            // Anonymous method with Action delegate
            Action<double> square = delegate (double param1)
            {
                Console.WriteLine($"Square {param1 * param1}");
            };

            square(4.2);


            // Lambda expression with Action delegate

            //Action<string> getStr = param1 => Console.WriteLine(param1);
            // OR following
            Action<string> getStr = (string param1) => Console.WriteLine(param1);
            getStr("Aijaz Ali Abro");
        }

        static void Add(double param1, int param2)
        {
            Console.WriteLine(param1 + param2);
        }
    }
}
