namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Unit_Tests tests = new Unit_Tests();
            try
            {
                tests.Addition_Test();
                Console.WriteLine("Test 1 has passed");
                tests.Substraction_Test();
                Console.WriteLine("Test 2 has passed");
                tests.Multiplication_Test();
                Console.WriteLine("Test 3 has passed");
                tests.Division_Normal_Test();
                Console.WriteLine("Test 4 has passed");
                tests.Division_Zero_Test();
                Console.WriteLine("Test 5 has passed");
                tests.Exception_Test();
                Console.WriteLine("Test 6 has passed");

                Console.WriteLine("All tests have successfully passed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
