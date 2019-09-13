using ConsoleGame.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.PlayerNS {
    public class Wizard : Player {
        public Item Spell { get; set; }
        public int Power { get; set; }
         
        public Wizard() {
            this.AddInv(20);
        }
    }
}
