using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_vide
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.nom = "toto";
            p1.age = 12;
            Model1Container m = new Model1Container();
            foreach (var p in m.PersonneSet)
            {
                Console.WriteLine(p);
            }
            m.PersonneSet.Add(p1);
            m.SaveChanges();

            foreach (var p in m.PersonneSet)
            {
                Console.WriteLine(p);
            }
        }
    }
}
