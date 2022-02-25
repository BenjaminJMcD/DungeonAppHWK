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

            //player = elf;

            //Console.WriteLine("\n\n\n" + player);

            //Console.WriteLine("\n\n\n" + elf);'
            //Console.WriteLine(OrcArmor);

            //OrcArmor orcArmor = new OrcArmor();

            //Broadsword broadsword = new Broadsword();

            player = elf;

            MouthOfSauron mouthOfSauron = new MouthOfSauron();

            //player.EquippedWeapon = broadsword;

            //Console.WriteLine(player);

            //Console.WriteLine(player.Life);
            //Console.WriteLine(player.EquippedWeapon);

            //Console.WriteLine(broadsword);

            bool exit = false;

            do
            {


                bool reload = false;
                do
                {

                    Console.WriteLine("CHOOSE YOUR FATE\n" +
                        "A TTACK\n" +
                        "P LAYER" +
                        "R UN\n" +
                        "X IT");



                    ConsoleKey flipburgers = Console.ReadKey(true).Key;
                    switch (flipburgers)
                    {
                        case ConsoleKey.A:

                            Combat.DoBattle(player, mouthOfSauron);
                            Console.WriteLine(player);
                            Console.WriteLine(mouthOfSauron);

                            if (mouthOfSauron.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed The Mouth of Sauron!\n");
                                Console.ResetColor();
                                reload = true;
                            }
                            if (player.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nYou DEAD");
                                Console.ResetColor();
                                reload = true;
                            }

                            break;

                        case ConsoleKey.X:

                            reload = true;
                            exit = true;
                            break;

                        case ConsoleKey.P:

                            Console.WriteLine(player);
                            break;
                    }


                } while (!reload);



            } while (!exit);
            Console.WriteLine("END OF GAME");

        }
    }
}
