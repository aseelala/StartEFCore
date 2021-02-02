using System;
using System.Reflection;
using Model.Repositories;
using System.Linq;

namespace UI
{
    class Program
    {
        //private static readonly EFOpleidingenContext context = new EFOpleidingenContext();
        static void Main(string[] args)
        {
            string keuze = string.Empty;
            while (keuze.ToUpper() != "X")
            {
                //Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("----");
                Console.WriteLine("Menu");
                Console.WriteLine("----");
                Console.WriteLine(" 1 - Menu item");
                //Console.WriteLine(" . . . . ");
                // . . . . 
                // P l a a t s h i e r d e v e r s c h i l l e n d e m e n u i t e m s
                // . . . .
                Console.Write("Keuze ('X' om te stoppen): ");
                keuze = Console.ReadLine();

                Console.WriteLine("----------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                if (keuze.ToUpper() != "X")
                {
                    // Reflection 
                    Program p = new Program();
                    Type t = p.GetType();
                    try
                    {
                        MethodInfo mi = t.GetMethod("Item" + "00".Substring(0, -keuze.Length + 2) + keuze, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                         mi.Invoke(p, null);
                        //string result = mi.Invoke(p, new object[] { par1, par2 }).ToString(); 
                    }
                    catch
                    {
                        Console.WriteLine("Ongeldige keuze");
                    }
                }
                //switch (keuze) //{ // case "X": case "x": break; // case "1": { Item01(); break; } // // . . . . // // default: // { // Console.WriteLine("Ongeldige keuze"); // break; // } //} // === // End // === 
                if (keuze.ToUpper() == "X")
                    break;
                Console.WriteLine("\nDruk een toets");
                Console.ReadKey(); Console.Clear();
            }
        }
        // --------- // Menu-item // --------- 

        // 1 - Queries - De foreach iteratie - beperkt: Je kan niet sorteren of filteren
        static void Item01()
        {
            using var context = new EFOpleidingenContext();
            foreach (var docent in context.Docenten)
            {
                Console.WriteLine(docent.Naam);
            }
        }

        // 2 - Een Linq-query 
        static void Item02()
        {
            Console.Write("Minimum wedde:");
            if (decimal.TryParse(Console.ReadLine(), out decimal minWedde))
            {
                using var context = new EFOpleidingenContext();
                var docenten = from docent in context.Docenten
                               where docent.Wedde >= minWedde
                               orderby docent.Voornaam, docent.Familienaam
                               select docent;
                foreach (var docent in docenten)
                {
                    Console.WriteLine($"{docent.Naam}: { docent.Wedde}");
                }
            }
            else
            {
                Console.WriteLine("Geef een getal in !");
            }
        }
    }
}