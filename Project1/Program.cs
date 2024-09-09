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

            Enemy blud = new Enemy("Blud", 100, 4, true, Weapons.LewisGun);
            Enemy pepa = new Enemy("Pepa", 80, 3, true, Weapons.F22);
            Console.WriteLine(blud);
            Console.WriteLine(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            blud.Attack(pepa);
            pepa.Attack(blud);
            blud.Heal(Potions.Large);
            pepa.Heal(Potions.Small);
            


            Console.WriteLine(blud);
            Console.WriteLine(pepa);
            Console.ReadLine();

            

        }
          

        

    }
    }

