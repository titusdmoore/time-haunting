using ConsoleGame.Models;
using ConsoleGame.Models.Items;
using ConsoleGame.Models.Mobs;
using ConsoleGame.Models.PlayerNS;
using System;

namespace ConsoleGame {
    class Program {
        static void Main(string[] args) {

            // Begin Home screen Code
            GameController.DisplayHome();

            /*
             * Begin Loop Booleans
             */
            var menu = true;
            var exit = false;

            // This is the main game boolean
            var run = false;
            // End loop Booleans

            Player instancePlayer = null;
            do {
                Console.WriteLine("Welcome To Time Haunting! Choose Option: ");
                Console.WriteLine(@"[S]tart Game       [C]reate Player       [P]layer List       [V]iew Credits       [E]xit");
                var t = InlineConsole.ReadPrompt("> ");
                if (t == InlineConsole.ee) {
                    GameController.EasterEgg();
                }
                // End Home Screen Code

                // Test User Input

                switch (InlineConsole.switchFormat(t)) {
                    case "s":
                        instancePlayer = Player.CreatePlayer();
                        run = true;
                        menu = false;
                        break;
                    case "c":
                        instancePlayer = Player.CreatePlayer();
                        menu = false;
                        run = true;
                        break;
                    case "p":
                        Console.WriteLine("This would be a list if I wasn't lazy");
                        break;
                    case "e":
                        Environment.Exit(1);
                        break;
                    case "v":
                        Console.WriteLine("Made by Titus Moore");
                        break;
                    default:
                        exit = false;
                        break;
                }

            } while (menu == true && exit == false);


            while (run) {
                GameController.DisplayHome();

                var mob = new Mob();
                mob.Name = "Alexei Chong";
                mob.SetLine($"Hello {instancePlayer.Name}, prepare to die");
                Console.WriteLine($"Welcome {instancePlayer.Name}. ");
                Console.ReadLine();

                var sword = new Weapon();
                sword.Name = "Sword";
                sword.Damage = 45;
                sword.Size = 23;
                instancePlayer.AddItem(sword);


                GameController.DisplayHome();
                Console.WriteLine($"You have run into a {InlineConsole.GetType(mob)} named {mob.Name}, he is flying on a matress with only socks. It is amazing that he is flying with how BEEFY he is, looks weak though... He says: ");
                mob.Speak();



                GameController.Controls(instancePlayer, mob);

                run = false;
            }
        }
    }
}
