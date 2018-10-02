using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class FNPlayer
    {
        public int ammo = 10;
        public float health;

        public float Attack(FNPlayer enemy)
        {
            float damage = 10;
            enemy.health -= damage;
            ammo--;
            return damage;
        }
        public void TakeDamage(float damage)
        {
            health -= damage;
        }
    }
}
