using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
namespace liste_2026_aleksa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<uint> a = new List<uint>();
            uint x = ~0u;                          
            a.Add(x);
            Console.WriteLine(a[0]);
            

        }
    }
}
 