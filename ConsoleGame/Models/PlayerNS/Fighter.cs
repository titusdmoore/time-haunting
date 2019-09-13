using ConsoleGame.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.PlayerNS {
    public class Fighter : Player {
        // Adds Weapon for fighter Class
        public Item Weapon { get; set; }
        public int Strength { get; set; }
        
        // Give Fighter 20 more armor default
        public Fighter() {
            this.AddArmor(20);
        }
    }
}
