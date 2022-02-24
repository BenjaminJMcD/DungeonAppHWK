using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using WeaponsLibrary;
using RaceLibrary;
using MonsterLibrary;

namespace Dungeon
{
    public class TroubleShooting
    {
        private static void Main(string[] args)
        {
            //    Hobbit hobbit = new Hobbit();
            //    Player player = new Player();
            //    Uruk_hai uruk = new Uruk_hai();
            //    Monster monster = new Monster();

            //    Console.WriteLine(hobbit);

            //    player = hobbit;
            //    monster = uruk;

            //    do
            //    {

            //    Combat.DoBattle(hobbit, uruk);


            //    } while (player.Life >= 0 & monster.Life >=0);

            NoWeapon noweapon = new NoWeapon();
            Player player = new Player();
            Elf elf = new Elf();

            //Elf elf = new Elf("Legolas", "An ageless Woodland Elf with a keen Eye", 60, 60, 30, 20, 90, 70, 15, noweapon);

            player = elf;

            Console.WriteLine("\n\n\n" + player);

            Console.WriteLine("\n\n\n" + elf);





        }

    }
}
