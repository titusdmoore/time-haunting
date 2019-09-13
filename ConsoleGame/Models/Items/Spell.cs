using ConsoleGame.Models.PlayerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Items {
    public class Spell : Item {
        public int EnCost { get; set; }
        public int ActionAmnt { get; set; }

        public void HealSpell(Player p) {
            //TODO test based on wizard energy maybe wizards get bonus perk
            p.Heal(this.ActionAmnt);
            Console.WriteLine($"You healed with {this.Name} for {this.ActionAmnt}");
        }

        public void AttackSpell(/*Enemy Instance*/) {

        }

    }
}
