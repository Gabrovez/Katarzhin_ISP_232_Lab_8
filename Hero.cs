using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }
        private int _health;
        private int _maxHealth;
        public Hero(string name, int maxHealth)
        {
            Name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            Mana = 100;
            Level = 1;
        }
        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
            }
        }
        public string Status
        {   
            get
            {
                if (Health > 0) return "Жив";
                else return "Делает спасбросок от смерти";
            }
        }
        public void TakeDamage(int damage)
        {
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} уже бросает кости и невосприимчив к урону.(можете сломать ему несколько точек с удара)");
                return;
            }
            Health -= damage;
            Console.WriteLine($"{Name} получает {damage} урона. Hp: {Health} | Статус: {Status}");
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} делает спасбросок от смерти");
            }
        }
        public void Heal(int amount)
        {
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} пока не хочет вставать, так что хил не сработал");
                return;
            }
            Health += amount;
            Console.WriteLine($"{Name} исцелён на {amount}. Hp: {Health} | Статус: {Status}");
        }
    }
}
