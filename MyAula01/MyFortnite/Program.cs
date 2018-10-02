using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            FNPlayer player = new FNPlayer();
            FNPlayer player2 = new FNPlayer(100, 50);

            Console.WriteLine("HP" + player.GetHealth());
            Console.WriteLine("HP" + player2.GetHealth());

            player.Attack(player2);

            Console.WriteLine("HP" + player.GetHealth());
            Console.WriteLine("HP" + player2.GetHealth());
        }
    }
}
