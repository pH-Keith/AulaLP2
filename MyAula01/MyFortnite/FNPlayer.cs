using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class FNPlayer
    {
        private int ammo;
        private float health;

        public FNPlayer()
        {
            ammo = 0;
            health = 100;
        }

        public FNPlayer(int ammo, float health)
        {
            this.ammo = ammo;
            SetHealth(health);
        }

        public float GetHealth()
        {
            return health;
        }
        public void SetHealth(float health)
        {
            if(health <= 100 && health >= 0)
            {
                this.health = health;
            }
        }

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
