using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100, 50, 50);
            Barbarian barbarian = new Barbarian(100,1,20,2);

            barbarian.getDamage(90);
            knight.getDamage(110);

            barbarian.showInfo();
            knight.showInfo();
            Console.ReadKey();
        }
    }

    class Warrior
    {
        protected int Health;
        protected int Armor;
        protected int Damage;

        public Warrior(int health, int armor, int damage)
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public void getDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void showInfo()
        {
            Console.WriteLine(Health);
        }
    }

    class Knight : Warrior
    {
        public Knight (int health, int armor, int damage) : base(health,armor,damage)
        {

        }
        public void Pray()
        {
            Armor += 2;
        }
    }

    class Barbarian : Warrior
    {

        public Barbarian(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed)
        {

        }

        public void Waaghh()
        {
            Armor -= 2;
            Health += 10;
        }
    }
}
