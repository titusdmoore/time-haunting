using ConsoleGame.Models.PlayerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Mobs {
    public class Mob {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public bool CanInteract { get; set; } = true;
        private string Line { get; set; }

        public void Hurt(int a) {
            this.Health =- a;
        }

        public void SetLine(string s) {
            if (this.CanInteract) {
                this.Line = s;
            }
        }

        public void Speak() {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(this.Line);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
