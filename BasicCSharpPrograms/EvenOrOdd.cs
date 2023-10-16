namespace BasicCSharpPrograms
{
    public class EvenOrOdd
    {
        public void Check()
        {
             int i;
            Console.Write("Enter a Number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }

            Console.Read();
        }
    }
}