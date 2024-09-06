using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Domain
{
    class Entity
    {
        protected int hp;
        protected int dmg;
        public string Name;
    }
    class Monster : Entity
    {
        private string sound;

        public void rawwww()
        {
            Console.WriteLine(sound);
        }
        public Monster(int hp, int dmg, string name, string sound)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.Name = name;
            this.sound = sound;
        }
        public void takeDamage(int dmg)
        {
            this.hp -= dmg;
            Console.WriteLine(this.hp);
        }
        public void Heal(int hp)
        {
            this.hp += hp;
            Console.WriteLine(this.hp);
        }
    }
}
