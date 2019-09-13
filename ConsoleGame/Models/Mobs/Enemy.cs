using ConsoleGame.Models.PlayerNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Mobs {
    public class Enemy : Mob {
        public int Damage { get; set; }

        public void Attack(Player p) {
            p.DamgArmor(this.Damage / 2);
        }
    }
}
