namespace Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditionals
            Console.WriteLine("please enter your temperature");
            String temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            
            if (numTemp < 20)
            {
                Console.WriteLine("Take your coat");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("pull over is good");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("shorts are good");
            }
            Console.ReadKey();
        }
    }
}