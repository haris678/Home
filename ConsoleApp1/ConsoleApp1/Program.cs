using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    SortedSet<string> ascending = new SortedSet<string>();
            //    Console.BackgroundColor = ConsoleColor.DarkRed;
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("\t\t\t*********TECHNOLOGIES************\n");
            //    ascending.Add("\t\tDecarbonization Rises");
            //    ascending.Add("\t\tCrops that make their own fertilizer");
            //    ascending.Add("\t\tDiagnosing diseases with a puff of breath");
            //    ascending.Add("\t\tMaking pharmaceuticals on demand");
            //    ascending.Add("\t\tEnergy from wireless signals");
            //    ascending.Add("\t\tEngineering a longer “healthspan”");
            //    ascending.Add("\t\tAmmonia goes green");
            //    ascending.Add("\t\tBiomarker devices go wireless");
            //    ascending.Add("\t\tinformation technology");
            //    ascending.Add("\t\tartificial intelligence");

            //    foreach (var item in ascending)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("\n\n\t\tNUMBER OF TECHNOLOGIES " + ascending.Count);

            //HashSet<string> stas = new HashSet<string>();
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("\t\t\t********STATIONARY ITEMS********");
            //stas.Add("\t\tSTAPLERS");
            //stas.Add("\t\tPEN CUPS");
            //stas.Add("\t\tPAPER CLIP");
            //stas.Add("\t\tPAPER CLIP");
            //stas.Add("\t\tSCISSORS");
            //stas.Add("\t\tSTICKY TAPES");

            //foreach (var item in stas)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("NUMBER OF ITEMS IS " + stas.Count);

            LinkedList<string> lang = new LinkedList<string>();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t*********PROGRAMING LANGUAGES*********");
            lang.AddFirst("\t\tHTML");
            lang.AddLast("\t\tCSS");
            lang.AddLast("\t\tJAVASCRIPT");
            lang.AddLast("\t\tC#");
            lang.AddLast("\t\tC++");
            lang.AddLast("\t\tNODE JS");
            lang.AddLast("\t\tPYTHON");
            lang.AddLast("\t\tPHP");
            lang.AddLast("\t\tRUBY");
            lang.AddLast("\t\tKOTLIN");

            foreach (var item in lang)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("NUMBER OF ITEM IS " + lang.Count);









        }
    }
}
