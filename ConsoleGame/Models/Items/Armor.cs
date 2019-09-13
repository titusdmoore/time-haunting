using ConsoleGame.Models.PlayerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Items {
    public class Armor {
        public int ArmorAmnt { get; set; }

        public void UseArmor(Player p) {
            p.AddArmor(this.ArmorAmnt);
            Console.WriteLine("You Added Armor");
        }
    }
}
