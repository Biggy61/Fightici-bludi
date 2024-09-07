using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Domain
{
    public enum Potions
    {
        Small = 1,
        Mid = 2,
        Large = 3,
    }
    enum Weapons
    {
        LewisGun = 1,
        AMRAAM = 2,
        F22 = 3
    }



    class Entity
    {
        public string Name;
    }
    class Enemy : Entity
    {
        public int hp;
        public int dmg;
        public bool IsLiving;

        
        public void Heal(Potions potion)
        {
            switch (potion)
            {
                case Potions.Small: this.hp += 5;
                    Console.WriteLine($"{this.Name} healed, remaining hp: {this.hp}");
                    break;
                case Potions.Mid: this.hp += 10;
                    Console.WriteLine($"{this.Name} healed, remaining hp: {this.hp}");
                    break;
                case Potions.Large: this.hp += 15;
                    Console.WriteLine($"{this.Name} healed, remaining hp: {this.hp}");
                    break;

            }
        }



        public void Attack(Enemy player)
            {
            player.hp -= this.dmg;
            if (player.hp > 0)
            {
              
                    Console.WriteLine($"{this.Name} attacks: {player.Name} and deals {this.dmg} dmg");
                  player.IsLiving = true;
            }
            else
            {
              player.hp = 0;
              player.IsLiving = false;
            }
              
 
             
        }







        public Enemy(string name, int hp, int dmg, bool IsLiving) 
        {
            this.Name = name;
            this.hp = hp;
            this.dmg = dmg;
            this.IsLiving = IsLiving;

        }
        public Enemy(string name, int hp, int dmg, bool IsLiving, Weapons weapon)
        {
            this.Name = name;
            this.hp = hp;
            this.dmg = dmg;
            this.IsLiving = IsLiving;
            Weapons weapons = weapon;
            switch (weapon)
            {
                case Weapons.LewisGun:
                    this.dmg += 5;
                    break;
                case Weapons.AMRAAM:
                    this.dmg += 10;
                    break;
                case Weapons.F22:
                    this.dmg += 15;
                    break;
            }
        }





        public override string ToString()
        {
            string obj = $"Name: {this.Name}, hp: {this.hp}, dmg: {this.dmg}, Alive: {this.IsLiving}";
            return obj;
        }
    }
}
