using System;

namespace Password
{
    class Program
    {
        static void Main()
        {
            int tentativi = default;
            string password = default, input = default;
            bool corretto = default;
            password = "Paninosalame";

            while (tentativi < 3 && !corretto)
            {
                Console.Write("Inserisci la password: ");
                input = Console.ReadLine();
                if(input == password)
                {
                    Console.Clear();
                    Console.WriteLine("Benvenuto, ecco la ricetta per un panino al salame:");
                    Console.WriteLine("- 1x Panino");
                    Console.WriteLine("- Fette di salame a piacere");
                    corretto = true;
                } else
                {
                    tentativi++;
                    Console.WriteLine("Password errata, riprova\n");
                }
            }
            if(tentativi == 3)
            {
                Console.WriteLine("Hai sbagliato la password troppe volte, trovati qualcos'altro da fare");
            }
            Console.WriteLine("\n\nPremi un tasto per terminare...");
            Console.ReadKey();
        }
    }
}
