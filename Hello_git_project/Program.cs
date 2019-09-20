using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_git_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            List<int> Lista = new List<int>();
            int darabszam = 0;
            Console.WriteLine("Kérem adja meg mennnyi számot tartalmazzon a tömb.");
            darabszam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < darabszam; i++)
            {
                Console.WriteLine("Adja meg a következő számot");
                szam = Convert.ToInt32(Console.ReadLine());
                Lista.Add(szam);
                
            }
            int max = Lista.Max();


            Console.WriteLine("A legnagyobb értékű szám:  " + max);
            Console.ReadKey();  
        }
    }
}
