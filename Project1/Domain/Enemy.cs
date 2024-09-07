/*
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
    
    public enum Weapons
        {
           bad = 5,
           good = 10,
           epic = 15
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
        
        }

        
        
        public void Heal(Potions potion)
        {
            this.hp += this.potion;
            Console.WriteLine(this.hp);
        }
        
        //, weapon: {this.Weapon}
        
    }
}
*/