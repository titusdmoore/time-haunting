using ConsoleGame.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Player {
    public class Player {
        public string Name { get; set; }
        private int Level { get; set; } = 1;
        private int Health { get; set; } = 100;
        private decimal Armor { get; set; } = 0;
        public decimal Cash { get; set; }
        public bool isDead { get; set; } = false;
        private List<Item> Inventory { get; set; }
        private int InvSpace { get; set; } = 100;

        /* 
        * METHODS FOR HEALTH
        */

        // Add Method to Add Health
        public void Heal(int a) {
            if (a > 0 && this.Health < 130) {
                this.Health = this.Health + a;
            }
        }

        // Add Method to Remove Health
        public void Hurt(int a) {
            if (this.Health > 0 && a < this.Health) {
                this.Health = this.Health - a;
            }else if(a >= this.Health) {
                Kill();
            }
        }

        // Add Method to kill
        public void Kill() {
            this.isDead = true;
            if (this.Level != 0) {
                this.Level = 0;
            }
            GameController.DisplayDead();
        }

        /*
         *  METHODS FOR ARMOR
         */

        // Add Method to Add Armor
        public void AddArmor(int a) {
            if (a > 0) {
                this.Armor = this.Armor + a;
            }
        }

        // Add Method to Damage Armor
        public void DamgArmor(int a) {
            if (this.Armor > 0 && a <= this.Armor ) {
                this.Armor = this.Armor - a;
            } else {
                this.Armor = 0;
            }
        }

        /*
         *  Begin Inventory Functions
         */
        
        // Add Inventory Space
        public void AddInv(int a) {
            this.InvSpace = this.InvSpace + a;
        }

        // Add item to inventory
        public void AddItem(Item i) {
            var space = 0;
            // Calculate Space in inventory
            foreach (var x in this.Inventory) {
                space = space + x.Size;
            }

            // Add item to inventory if enough space
            if (i.Size <= space) {
                this.Inventory.Add(i);
            } else {
                Console.WriteLine("You do not have enough space to add item!");
            }
        }

        // End Inventory Functions

        public static Player CreatePlayer() {
            GameController.PlayerCreator();
            //Prompt User Name
            Console.WriteLine("Enter Player Name");
            var nm = InlineConsole.ReadPrompt("> ");

            // Prompt User Type
            Console.WriteLine($"Enter Type");
            Console.WriteLine(@"[F]ighter       [W]izard       [S]peaker");
            var t = InlineConsole.ReadPrompt("> ");

            switch (InlineConsole.switchFormat(t)) {
                case "f":
                    var fighter = new Fighter();
                    fighter.Name = nm;
                    return fighter;
                case "w":
                    var wizard = new Wizard();
                    wizard.Name = nm;
                    return wizard;
                case "s":
                    var speaker = new Speaker();
                    speaker.Name = nm;
                    return speaker;
                default:
                    return null;
            }
        }
    }
}
