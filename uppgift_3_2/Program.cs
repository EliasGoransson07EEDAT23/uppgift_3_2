using System;
namespace moretestingtesting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej, är du intresserad av att jobba på Datorbygge AB?");
            Console.WriteLine("Men vad bra, först måste vi fråga några simpla frågor!");
            Console.WriteLine("");
            Console.WriteLine("Första frågan är; har du gått ut gymnasiet? Svara j för ja eller n för nej.");
            string gymnasie = Console.ReadLine();
            Console.WriteLine("Andra frågan är; hur gammal är du? Svara med ålder i siffror.");
            int age = int.Parse(Console.ReadLine());

            if (age <= 22 && gymnasie == "j")
            {
                Console.WriteLine("Okej, vi vill gärna anställa dig. Kom in till kontoret på tisdag för vidare information.");
            }
            else
            {
                Console.WriteLine("Okej, vi letar efter mer passande kollegor, men tack för visat intresse.");
            }
            Console.ReadKey();  


        }
    }
}