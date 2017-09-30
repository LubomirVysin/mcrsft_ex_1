using System;

namespace Microsoft_excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeManager changeManager = new ChangeManager();
            Console.WriteLine(changeManager.MakeChange(135));
            Console.ReadKey();
        }
    }
}
