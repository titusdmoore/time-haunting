using ConsoleGame.Models;
using ConsoleGame.Models.Player;
using System;

namespace ConsoleGame {
    class Program {
        static void Main(string[] args) {

            // Begin Home screen Code
            InlineConsole.DisplayHome();

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
                var tChar = " ";
                if (t == InlineConsole.ee) {
                    InlineConsole.EasterEgg();
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
                        exit = true;
                        break;
                    default:
                        break;
                }

            } while (menu == true && exit == false);
            while (run) {
                Console.WriteLine("This is where you play the game");
                Console.WriteLine($"Welcome {instancePlayer.Name}");
                run = false;
            }
        }
    }
}
