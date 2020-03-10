using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csillagoktab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sorok = new List<string>();
            StreamReader olvasó = new StreamReader("CsillagokTab.txt"); //egy egesz szöveget visszakomentelni ctrl k ctrl u
            while (!olvasó.EndOfStream)
            {
                sorok.Add(olvasó.ReadLine());
                
            }
            olvasó.Close();
            //string[] sorok2= File.ReadAllLines("Csillagoktab.txt");
            /*foreach (string sor in sorok)
            {
                Console.WriteLine(sorok[4]);
            }*/
            string aktsor = sorok[4];
            string[] soradatok = aktsor.Split('\t');
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
