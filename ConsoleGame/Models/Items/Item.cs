using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models.Items {
    public class Item {
        public string Name { get; set; }
        public int Size { get; set; }
        public decimal Cost { get; set; }
        public int Rarity { get; set; } // an int between 1 and 100 that an rng will be ran to determine spawn rate
        //TODO build out item class
    }
}
