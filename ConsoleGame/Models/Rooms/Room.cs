using ConsoleGame.Models.Items;
using ConsoleGame.Models.Mobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Rooms {
    public class Room {
        private int NumMobs { get; set; }
        private int NumItems { get; set; }
        public List<Mob> Mobs { get; set; }
        public List<Item> Items { get; set; }

        /*
         * METHODS FOR MOBS
         */

        public void GenerateMobCount() {
            Random random = new Random();
            var nums = new List<int>();
            var mobCnt = 0;

            for (int i = 0; i < 4; i++) {
                var rN = random.Next(1, 101);
                nums.Add(rN);
            }

            for (int i = 0; i < 5; i++) {
                var test = random.Next(1, 101);
                foreach (var item in nums) {
                    if (test == item) {
                        mobCnt++;
                    }
                }
            }
            this.NumMobs = mobCnt;
        }

        public void GenerateMobList(Mob[] ms) {
            for (int i = 0; i <= this.NumMobs; i++) {
                this.Mobs.Add(ms[i]);
            }
        }

        // END MOB METHODS

        /*
         *    METHODS FOR ITEMS
         */

        public void GenerateItemCount() {
            Random random = new Random();
            var nums = new List<int>();
            var iCnt = 0;

            for (int i = 0; i < 7; i++) {
                var rN = random.Next(1, 101);
                nums.Add(rN);
            }

            for (int i = 0; i < 14; i++) {
                var test = random.Next(1, 101);
                foreach (var item in nums) {
                    if (test == item) {
                        iCnt++;
                    }
                }
            }
            this.NumItems = iCnt;
        }

        public void GenerateItemList(Item[] ms) {
            for (int i = 0; i <= this.NumMobs; i++) {
                this.Items.Add(ms[i]);
            }
        }
    }
}
