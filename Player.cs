using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Player
    {
        public event Action OnDeath;
        private int hp = 100;
        private void Die()
        {
            Console.WriteLine("Player died");
            OnDeath?.Invoke();
        }
        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp <= 0)
            {
                Die();
            }
        }
    }
}
