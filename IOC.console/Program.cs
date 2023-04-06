using System;

namespace IOC.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            BL bl = new BL(new DAL());

            bl.GetProducts().ForEach(p =>
            {
                Console.WriteLine(p.Id);
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Price);
                Console.WriteLine(p.Stock);
            });


            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
