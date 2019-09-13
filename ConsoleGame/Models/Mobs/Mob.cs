using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Mobs {
    public class Mob {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool CanInteract { get; set; }

        public void Hurt(int a) {
            this.Health =- a;
        }
    }
}
