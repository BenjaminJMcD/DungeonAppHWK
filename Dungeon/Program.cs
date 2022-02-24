﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;
using WeaponsLibrary;
using RaceLibrary;


namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();
            Monster monster = new Monster();


            bool exit = false;

            do
            {

                Console.Title = "****Infiltrate Mordor!****";

                Console.WriteLine("\n\n\n\nAs Sauron's forces begin to grow stronger and mobilize, the few remaining from the fellowship of 9 await their chance to confront Mordor as their last stand. After discussion, it is decided that a warrior should be sent to aid Frodo and Sam... or to finish what they were sent out to do.");

                NoWeapon noweapon = new NoWeapon();
                Hobbit hobbit = new Hobbit();
                Dwarf dwarf = new Dwarf();
                Human human = new Human();
                Elf elf = new Elf();
                BrownWizard brownwizard = new BrownWizard();
                WhiteWizard whitewizard = new WhiteWizard();

                bool begin = false;
                do
                {
                    Console.Write("\nChoose your warrior!\n\n" +
                        "H) Hobbits\n" +
                        "D) Dwarf\n" +
                        "M) Man\n" +
                        "E) Elf\n" +
                        "B) Brown Wizard\n" +
                        "W) White Wizard\n\n" +
                        "X to Exit");


                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.H:

                            Console.WriteLine(hobbit);

                            Console.WriteLine("\n\nIf you choose Hobbits, press Y\n" +
                                "Press any other button to reload menu");

                            ConsoleKey yesOrNo = Console.ReadKey(true).Key;

                            switch (yesOrNo)
                            {
                                case ConsoleKey.Y:
                                    player = hobbit;
                                    begin = true;
                                    Console.Clear();
                                    break;

                                default:
                                    begin = false;
                                    Console.Clear();
                                    break;
                            }
                            break;

                        case ConsoleKey.D:

                            Console.WriteLine(dwarf);

                            Console.WriteLine("\n\nIf you choose Dwarf, press Y\n" +
                            "Press any other button to reload menu");

                            ConsoleKey yeaOrNay = Console.ReadKey(true).Key;

                            switch (yeaOrNay)
                            {
                                case ConsoleKey.Y:
                                    player = dwarf;
                                    begin = true;
                                    Console.Clear();
                                    break;

                                default:
                                    begin = false;
                                    Console.Clear();
                                    break;
                            }
                            break;

                        case ConsoleKey.M:

                            Console.WriteLine(human);

                            Console.WriteLine("\n\nIf you choose Human, press Y\n" +
                            "Press any other button to reload menu");

                            ConsoleKey yassOrNahh = Console.ReadKey(true).Key;

                            switch (yassOrNahh)
                            {
                                case ConsoleKey.Y:
                                    player = human;
                                    begin = true;
                                    Console.Clear();
                                    break;

                                default:
                                    begin = false;
                                    Console.Clear();
                                    break;
                            }
                            break;

                        case ConsoleKey.E:

                            Console.WriteLine(elf);

                            Console.WriteLine("\n\nIf you choose Elf, press Y\n" +
                            "Press any other button to reload menu");

                            ConsoleKey yapOrNap = Console.ReadKey(true).Key;

                            switch (yapOrNap)
                            {
                                case ConsoleKey.Y:
                                    player = elf;
                                    begin = true;
                                    Console.Clear();
                                    break;

                                default:
                                    begin = false;
                                    Console.Clear();
                                    break;
                            }
                            break;

                        case ConsoleKey.B:

                            Console.WriteLine(brownwizard);

                            Console.WriteLine("\n\nIf you choose the Brown Wizard, press Y\n" +
                            "Press any other button to reload menu");

                            ConsoleKey yoOrHo = Console.ReadKey(true).Key;

                            switch (yoOrHo)
                            {
                                case ConsoleKey.Y:
                                    player = brownwizard;
                                    begin = true;
                                    Console.Clear();
                                    break;

                                default:
                                    begin = false;
                                    Console.Clear();
                                    break;
                            }
                            break;

                        case ConsoleKey.W:

                            Console.WriteLine(whitewizard);

                            Console.WriteLine("\n\nIf you choose the White Wizard, press Y\n" +
                            "Press any other button to reload menu");

                            ConsoleKey yeOrNe = Console.ReadKey(true).Key;

                            switch (yeOrNe)
                            {
                                case ConsoleKey.Y:
                                    player = whitewizard;
                                    begin = true;
                                    Console.Clear();
                                    break;

                                default:
                                    begin = false;
                                    Console.Clear();
                                    break;
                            }
                            break;

                        case ConsoleKey.X:
                            exit = true;
                            begin = true;
                            break;

                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\nSpeak UP young laddy!\n");
                            Console.ResetColor();
                            begin = false;
                            break;
                    }
                } while (!begin && !exit);


                Console.WriteLine("\nLEVEL ONE - MYSTERIOUS CAVE\n\n" +
                    "You are brought to a dark cave outside Mordor's front gates that reeks of death and foul meat.....\n\n");

                bool frodo = false;
                do
                {

                    Console.WriteLine("Are you brave enough to enter ?\n\n" +
                        "Y) Yes...\n" +
                        "N) No. Exit Game\n" +
                        "F) For Frodo n Sam.");

                    ConsoleKey forFrodo = Console.ReadKey(true).Key;

                    switch (forFrodo)
                    {
                        case ConsoleKey.Y:
                        case ConsoleKey.F:
                            frodo = true;
                            Console.Clear();
                            break;
                        case ConsoleKey.N:
                            frodo = true;
                            exit = true;
                            break;
                        default:
                            frodo = false;
                            Console.WriteLine("\n\nSpeak up laddy!\n\n");
                            break;
                    }
                } while (!frodo && !exit);
            if (exit) break;

            Shelob shelob = new Shelob();
            Orc halfdeadOrc = new Orc("Half-dead Orc", "The creature is confused and in panic. Nearly all life has left its eyes...", 50, 15, 15, 1, 40, 1, 5, 20);

            Console.WriteLine("\nLEVEL ONE - MYSTERIOUS CAVE\n\n" +
                    "There is still some light from the opening.. but this cave has no end in sight");

            int score = 0;

                Random random = new Random();
                int dice = random.Next(1, 101);

                if (dice <= 30)
                {
                    Console.WriteLine("\nA Foe Appears!!\n\n" + (shelob));

                    bool again = true;
                    do
                    {
                        Console.WriteLine("\n\nWhat do you do...\n\n" +
                            "A) Attack\n" +
                            "R) Run\n" +
                            "P) Player Stats\n" +
                            "X) Exit Game");

                        ConsoleKey userBattle = Console.ReadKey(true).Key;

                        switch (userBattle)
                        {
                            case ConsoleKey.A:

                                Combat.DoAttack(player, monster);
                                Combat.DoAttack(monster, player);

                                if (monster.Life <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You killed Shelob!");
                                    Console.ResetColor();
                                    score++;
                                    again = false;
                                }
                                if (player.Life <= 0)
                                {
                                    Console.WriteLine("You died....");
                                    again = false;
                                    exit = true;
                                }
                                else
                                {
                                    Console.WriteLine("The cursed creature retreated to the darkness!");
                                    again = false;
                                }
                                break;

                            case ConsoleKey.R:
                                Console.WriteLine("You run deeper into the cave to hide!");
                                Combat.DoAttack(shelob, player);
                                Console.WriteLine("'Vile creature!' You are stabbed as you run away");
                                break;

                            case ConsoleKey.P:
                                Console.WriteLine(player);
                                again = true;
                                break;

                            case ConsoleKey.X:
                                exit = true;
                                again = false;
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Try again!");
                                again = true;
                                break;
                        }//end switch
                    } while (again);
                }//end if

            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);

                if (diceRoll > 30 && diceRoll <= 50) 
                {
                    Console.Clear();
                    Console.WriteLine("\nSomething desperately grasps your arm .\n\n" + (halfdeadOrc));
                    bool next = false;
                    do
                    {
                        Console.WriteLine("\n\nWhat do you do...\n\n" +
                            "A) Attack\n" +
                            "R) Run\n" +
                            "P) Player Stats\n" +
                            "X) Exit Game");

                        ConsoleKey cavesBattle = Console.ReadKey(true).Key;
                        switch (cavesBattle)
                        {
                            case ConsoleKey.A:
                                Combat.DoBattle(player, halfdeadOrc);
                                if (monster.Life <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You ended his life.");
                                    Console.ResetColor();
                                    score++;
                                    next = true;
                                }
                                if (player.Life <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You died....");
                                    Console.ResetColor();
                                    next = true;
                                    exit = true;
                                }
                                break;

                            case ConsoleKey.R:
                                Console.Clear();
                                Console.WriteLine("You run further into the darkness");
                                next = true;
                                break;

                            case ConsoleKey.P:  //AnyKey crashes console
                                Console.Clear();
                                Console.WriteLine(player);
                                Console.WriteLine("\n\nPress any key to return to Menu");
                                next = false;
                                return;

                            case ConsoleKey.X:
                                exit = true;
                                next = true;
                                break;
                        }//end switch
                    } while (!next);
                }//end if

            if (diceRoll > 50)  //STUCK. P does NOTHING
            {
                bool noenemy = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("There is still a bit of light from the entrance... What shall you do?\n\n" +
                        "P) Player Stats\n" +
                        "S) Search Area\n" +
                        "C) Continue Onward\n" +
                        "X) Exit Game");

                    ConsoleKey stillness = Console.ReadKey(true).Key;
                    switch (stillness)
                    {
                        case ConsoleKey.P:
                            Console.WriteLine(player);
                            Console.WriteLine("\n\nPress any key to return to menu");
                            noenemy = true;
                            break;
                        case ConsoleKey.C:
                            noenemy = false;
                            break;
                        //case ConsoleKey.S:
                        //            Random dice = new Random();
                        //            int roll = dice.Next(1, 101);
                        //       if (roll <= 30)
                        //        {
                        //            Console.WriteLine(" You've discovered\n\n" EquippedWeapon() "\n\n...on one of the corpses! Equip?");    //TODO - BUILD RANDOM WEAPON PICKUP
                        //        }
                        //    break;

                        default:
                            Console.WriteLine("Try again, laddy");
                            noenemy = true;
                            break;
                    }
                } while (noenemy);
            }

            Console.WriteLine("\nLEVEL ONE - MYSTERIOUS CAVE\n" +
            "The air is thick and putrid. Things are so dark now. We need to be careful");

            if (diceRoll <= 30)
            {
                Console.Clear();
                Console.WriteLine("\nA Foe Appears!!\n\n" + (shelob));

                Console.WriteLine("\n\nWhat do you do...\n\n" +
                    "A) Attack\n" +
                    "R) Run\n" +
                    "P) Player Stats\n" +
                    "X) Exit Game");

                ConsoleKey userBattle = Console.ReadKey(true).Key;

                switch (userBattle)
                {
                    case ConsoleKey.A:

                        Combat.DoAttack(player, monster);
                        Combat.DoAttack(monster, player);

                        if (monster.Life <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You killed Shelob!");
                            Console.ResetColor();
                            score++;
                        }
                        if (player.Life <= 0)
                        {
                            Console.WriteLine("You died....");
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("The cursed creature retreated to the               darkness!");
                        }
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine("You run deeper into the cave to hide!");
                        Combat.DoAttack(shelob, player);
                        Console.WriteLine("'Vile creature!' You are stabbed as you          run away");
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        break;
                }//end switch
            }
            if (diceRoll > 30 && diceRoll <= 50)
            {
                Console.Clear();
                Console.WriteLine("\nSomething desperately grasps your arm .\n\n" + (halfdeadOrc));
                bool next = false;
                do
                {
                    Console.WriteLine("\n\nWhat do you do...\n\n" +
                        "A) Attack\n" +
                        "R) Run\n" +
                        "P) Player Stats\n" +
                        "X) Exit Game");

                    ConsoleKey cavesBattle = Console.ReadKey(true).Key;
                    switch (cavesBattle)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, halfdeadOrc);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You killed Shelob!");
                                Console.ResetColor();
                                score++;
                                next = true;
                            }
                            if (player.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died....");
                                Console.ResetColor();
                                exit = true;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.Clear();
                            Console.WriteLine("You run further into the darkness");
                            next = true;
                            break;

                        case ConsoleKey.P:
                            Console.Clear();
                            Console.WriteLine($"{ player }" +
                               "\n\nPress any key to return to Menu");
                            next = false;
                            return;

                        case ConsoleKey.X:
                            exit = true;
                            break;
                    }//end switch
                } while (next == false);
            }
            if (diceRoll > 50)
                Console.Clear();

            Console.WriteLine("\nLEVEL ONE - MYSTERIOUS CAVE\n" +
            "There may be some light at the end of this pathway!");

            if (diceRoll <= 30)
            {
                Console.Clear();
                Console.WriteLine("\nA Foe Appears!!\n\n" + (shelob));

                Console.WriteLine("\n\nWhat do you do...\n\n" +
                    "A) Attack\n" +
                    "R) Run\n" +
                    "P) Player Stats\n" +
                    "X) Exit Game");

                ConsoleKey userBattle = Console.ReadKey(true).Key;

                switch (userBattle)
                {
                    case ConsoleKey.A:

                        Combat.DoAttack(player, monster);
                        Combat.DoAttack(monster, player);

                        if (monster.Life <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You killed Shelob!");
                            Console.ResetColor();
                            score++;
                        }
                        if (player.Life <= 0)
                        {
                            Console.WriteLine("You died....");
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("The cursed creature retreated to the               darkness!");
                        }
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine("You run deeper into the cave to hide!");
                        Combat.DoAttack(shelob, player);
                        Console.WriteLine("'Vile creature!' You are stabbed as you          run away");
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        break;
                }//end switch
            }
            if (diceRoll > 30 && diceRoll <= 50)
            {
                Console.Clear();
                Console.WriteLine("\nSomething desperately grasps your arm .\n\n" + (halfdeadOrc));
                bool next = false;
                do
                {
                    Console.WriteLine("\n\nWhat do you do...\n\n" +
                        "A) Attack\n" +
                        "R) Run\n" +
                        "P) Player Stats\n" +
                        "X) Exit Game");

                    ConsoleKey cavesBattle = Console.ReadKey(true).Key;
                    switch (cavesBattle)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, halfdeadOrc);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You killed Shelob!");
                                Console.ResetColor();
                                score++;
                                next = true;
                            }
                            if (player.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died....");
                                Console.ResetColor();
                                exit = true;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.Clear();
                            Console.WriteLine("You run further into the darkness");
                            next = true;
                            break;

                        case ConsoleKey.P:
                            Console.Clear();
                            Console.WriteLine($"{ player }" +
                               "\n\nPress any key to return to Menu");
                            next = false;
                            return;

                        case ConsoleKey.X:
                            exit = true;
                            break;
                    }//end switch
                } while (next == false);
            }
            if (diceRoll > 50)
                Console.Clear();

            Console.WriteLine("\nLEVEL ONE - MYSTERIOUS CAVE\n" +
            "I can see the way out! Not 30 feet from where I stand.");

            if (diceRoll <= 30)
            {
                Console.Clear();
                Console.WriteLine("\nA Foe Appears!!\n\n" + (shelob));

                Console.WriteLine("\n\nWhat do you do...\n\n" +
                    "A) Attack\n" +
                    "R) Run\n" +
                    "P) Player Stats\n" +
                    "X) Exit Game");

                ConsoleKey userBattle = Console.ReadKey(true).Key;

                switch (userBattle)
                {
                    case ConsoleKey.A:

                        Combat.DoAttack(player, monster);
                        Combat.DoAttack(monster, player);

                        if (monster.Life <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You killed Shelob!");
                            Console.ResetColor();
                            score++;
                        }
                        if (player.Life <= 0)
                        {
                            Console.WriteLine("You died....");
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("The cursed creature retreated to the               darkness!");
                        }
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine("You run deeper into the cave to hide!");
                        Combat.DoAttack(shelob, player);
                        Console.WriteLine("'Vile creature!' You are stabbed as you          run away");
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        break;
                }//end switch
            }
            if (diceRoll > 30 && diceRoll <= 50)
            {
                Console.Clear();
                Console.WriteLine("\nSomething desperately grasps your arm .\n\n" + (halfdeadOrc));
                bool next = false;
                do
                {
                    Console.WriteLine("\n\nWhat do you do...\n\n" +
                        "A) Attack\n" +
                        "R) Run\n" +
                        "P) Player Stats\n" +
                        "X) Exit Game");

                    ConsoleKey cavesBattle = Console.ReadKey(true).Key;
                    switch (cavesBattle)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, halfdeadOrc);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You killed Shelob!");
                                Console.ResetColor();
                                score++;
                                next = true;
                            }
                            if (player.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died....");
                                Console.ResetColor();
                                exit = true;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.Clear();
                            Console.WriteLine("You run further into the darkness");
                            next = true;
                            break;

                        case ConsoleKey.P:
                            Console.Clear();
                            Console.WriteLine($"{ player }" +
                               "\n\nPress any key to return to Menu");
                            next = false;
                            return;

                        case ConsoleKey.X:
                            exit = true;
                            break;
                    }//end switch
                } while (next == false);
            }
            if (diceRoll > 50)
                Console.Clear();

            Console.WriteLine("\nLEVEL ONE - MYSTERIOUS CAVE\n" +
            "So close!");

            if (diceRoll <= 30)
            {
                Console.Clear();
                Console.WriteLine("\nA Foe Appears!!\n\n" + (shelob));

                Console.WriteLine("\n\nWhat do you do...\n\n" +
                    "A) Attack\n" +
                    "R) Run\n" +
                    "P) Player Stats\n" +
                    "X) Exit Game");

                ConsoleKey userBattle = Console.ReadKey(true).Key;

                switch (userBattle)
                {
                    case ConsoleKey.A:

                        Combat.DoAttack(player, monster);
                        Combat.DoAttack(monster, player);

                        if (monster.Life <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You killed Shelob!");
                            Console.ResetColor();
                            score++;
                        }
                        if (player.Life <= 0)
                        {
                            Console.WriteLine("You died....");
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("The cursed creature retreated to the               darkness!");
                        }
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine("You run deeper into the cave to hide!");
                        Combat.DoAttack(shelob, player);
                        Console.WriteLine("'Vile creature!' You are stabbed as you          run away");
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        break;
                }//end switch
            }
            if (diceRoll > 30 && diceRoll <= 50)
            {
                Console.Clear();
                Console.WriteLine("\nSomething desperately grasps your arm .\n\n" + (halfdeadOrc));
                bool next = false;
                do
                {
                    Console.WriteLine("\n\nWhat do you do...\n\n" +
                        "A) Attack\n" +
                        "R) Run\n" +
                        "P) Player Stats\n" +
                        "X) Exit Game");

                    ConsoleKey cavesBattle = Console.ReadKey(true).Key;
                    switch (cavesBattle)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, halfdeadOrc);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You killed Shelob!");
                                Console.ResetColor();
                                score++;
                                next = true;
                            }
                            if (player.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died....");
                                Console.ResetColor();
                                exit = true;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.Clear();
                            Console.WriteLine("You run further into the                         darkness");
                            next = true;
                            break;

                        case ConsoleKey.P:
                            Console.Clear();
                            Console.WriteLine($"{ player }" +
                               "\n\nPress any key to return to Menu");
                            next = false;
                            return;

                        case ConsoleKey.X:
                            exit = true;
                            break;
                    }//end switch
                } while (next == false);
            }
            if (diceRoll > 50)
                Console.Clear();

            Console.WriteLine();








            } while (!exit);

            //Exit Screen
            Console.WriteLine("\n\nFare thee well...");

        }
    }
}
