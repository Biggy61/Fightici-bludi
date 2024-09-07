using Project1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy blud = new Enemy("Blud", 200, 4, true,);
            Enemy pepa = new Enemy("Pepa", 150, 3, true);
            Console.WriteLine(blud);
            Console.WriteLine(pepa);
            blud.Attack(pepa);
            pepa.Attack(blud);
            blud.Heal(Large);



            Console.WriteLine(blud);
            Console.WriteLine(pepa);
            Console.ReadLine();

            

        }
          

        

    }
    }

