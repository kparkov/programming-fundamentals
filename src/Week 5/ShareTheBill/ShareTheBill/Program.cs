using System;

namespace ShareTheBill
{
    class Program
    {
        static void Main(string[] args)
        {
            var billApp = new BillSharingApplication();
            billApp.Run();
            Console.ReadKey();
        }
    }
}
