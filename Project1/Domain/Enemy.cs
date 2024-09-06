using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Domain
{
    enum Potions
        {
            small = 5,
            medium = 10,
            big = 15
        }
    /*
    public enum Weapons
        {
           bad = 5,
           good = 10,
           epic = 15
        }*/
    class Enemy
    {
        public int hp;
        public int dmg;
        public string Name;
        //public Weapons Weapon;
    }
    class Warrior : Enemy
    {
//Weapons weapon
        public Warrior(int hp, int dmg, string name)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.Name = name;
            //this.Weapon = weapon;
        void Attack()
        {
         
            if (this.hp > 0) { 
            this.hp -= dmg;
            
            }
            
        }
        }

        
        /*
        public void Heal(Potions potion)
        {
            this.hp += this.potion;
            Console.WriteLine(this.hp);
        }
        */
        //, weapon: {this.Weapon}
        public override string ToString()
        {
            string obj = $"Name: {this.Name}, hp: {this.hp}, dmg:{this.dmg}";
            return obj;
        }
    }
}
