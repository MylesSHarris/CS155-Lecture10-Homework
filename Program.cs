using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{

    class Alien
    {
        private int health; //0 = dead, 100 = full
        private string name;

        public Alien(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        public int Health { get { return health; } set { health = value; } }
        public string Name { get { return name; } set { name = value; } }

        public virtual int GetDamage() { return 0; }
    }

    class SnakeAlien : Alien
    {
        public SnakeAlien(int health, string name) : base(health, name)
        { }

        public override int GetDamage() { return 10; }
    }

    class OgreAlien: Alien
    {
        public OgreAlien(int health, string name) : base(health, name)
        { }

        public override int GetDamage() { return 6; }
    }

    class MarshmallowManAlien: Alien
    {
        public MarshmallowManAlien(int health, string name) : base(health, name)
        { }

        public override int GetDamage() { return 1; }
    }

    class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;

            foreach (Alien a in aliens)
            {
                damage += a.GetDamage();
            }
            return damage;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            AlienPack pack = new AlienPack(5);
            pack.AddAlien(new SnakeAlien(50, "John"), 0);
            pack.AddAlien(new SnakeAlien(50, "Dave"), 1);
            pack.AddAlien(new OgreAlien(50, "Joe"), 2);
            pack.AddAlien(new Alien(50, "Normal"), 3);
            pack.AddAlien(new MarshmallowManAlien(50, "Marsh"), 4);

            Console.WriteLine(pack.CalculateDamage());
        }
    }
}
