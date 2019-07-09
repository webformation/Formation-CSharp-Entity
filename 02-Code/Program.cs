using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 m = new Model1();
            var liste = m.Personnes;
            foreach(var p in liste)
            {
                Console.WriteLine(p);
            }
            Personne p1 = new Personne();
            p1.nom = "Jean";
            p1.age = 30;
            m.Personnes.Add(p1);
            m.SaveChanges();
        }
    }
}
