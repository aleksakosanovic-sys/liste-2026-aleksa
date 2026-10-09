using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography;
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
            a.Add(15);
            a.Add(29);
            a.Add(34);
             
            Console.WriteLine(a[0]);

            //stack

            Stack<int> v = new Stack<int>();
            v.Push(5);
            v.Push(10);
            v.Push(15);
            int u = v.Pop();
            Console.WriteLine(u);

            //red

            Queue<string> red = new Queue<string>();
            red.Enqueue("Andrej");
            red.Enqueue("Aleksa");
            red.Enqueue("Jaksa");
            string sledeci = red.Dequeue();
            sledeci = red.Dequeue();
            Console.WriteLine(sledeci);

            List<grana> m = new List<grana>();

            grana nova = new grana(2, 5);
            m.Add(nova);
            for (int i = 0; i < 5; ++i)
            {
                m[i].cvor = i + 5;
                m[i].tezina = i + 5;
                Console.WriteLine(m[i].cvor + " " + m[i].tezina);
            }
        }


    }
}
 