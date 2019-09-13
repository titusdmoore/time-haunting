using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Models {
    public static class InlineConsole {
        public static string ee { get; set; } = "Oh yeah, its all coming together";

        // Read Line with prompt
        public static string ReadPrompt(string p) {
            Console.Write(p);
            return Console.ReadLine();
        }

        // Get Char from String
        public static string switchFormat(string s) {
            var arr = s.ToCharArray();
            return arr[0].ToString().ToLower();
        }

        // Get type of object
        public static string GetType(Object o) {
            var t = o.GetType().ToString();
            var cS = t.Split('.');

            return cS[cS.Length - 1];
            
        }
    }
}
