using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {

        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(300);

            if (diceRoll <= attacker.CalcHitChance() &&  diceRoll <= defender.CalcBlockChance() && attacker.CalcDamage() >= defender.CalcBlockAmount())
            {
                int damageDealt = attacker.CalcDamage() - defender.CalcBlockAmount();
                defender.Life -= damageDealt;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} was blocked for {1} damage! But still managed {2}",
                    attacker.Name, defender.CalcBlockAmount(), damageDealt);
                Console.ResetColor();
            }

            if (diceRoll <= attacker.CalcHitChance() && diceRoll > defender.CalcBlockChance())
            {
                Console.Clear();
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} was hit for {1} damage!!",
                    defender.Name, damageDealt);
                Console.ResetColor();
            }

            if (diceRoll <= attacker.CalcHitChance() && diceRoll <= defender.CalcBlockChance() && attacker.CalcDamage() <= defender.CalcBlockAmount())
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} was blocked!!!",
                    attacker.Name);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }//end DoAttack



        public static void DoBattle(Player player, Monster monster)
        {
        do
	    {
            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }

	    } while (monster.Life > 0 && player.Life > 0);
        }//end DoBattle






    }
}
