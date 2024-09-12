using Project1.Classes;
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
            Random rng = new Random();
            Console.WriteLine("Name of your Character"); 
            String enemy1 = Console.ReadLine();
            Console.WriteLine("Name of enemy Character");
            String enemy2 = Console.ReadLine();
            Enemy blud = new Enemy(enemy1, 40, 4, true, Weapons.F22);
            Enemy pepa = new Enemy(enemy2, 80, 3, true, Weapons.AMRAAM);
            Console.WriteLine(blud);
            Console.WriteLine(pepa);
            Console.WriteLine("Press 1 for attack or 2 for heal;");

            while (blud.IsLiving & pepa.IsLiving)
            {
                int Fight = Convert.ToInt32(Console.ReadLine());
                switch (Fight)
                {
                    case 1:
                        blud.Attack(pepa);
                        pepa.Attack(blud);
                        Console.WriteLine(blud);
                        Console.WriteLine(pepa);
                        break;
                    case 2:
                        blud.Heal(Potions.Small);
                        int rand = rng.Next(1, 101);
                        if (rand <= 70)
                        {
                            pepa.Heal(Potions.Large);
                        }
                        break;

                }
            }

            Console.ReadLine();

            

        }
          

        

    }
    }

