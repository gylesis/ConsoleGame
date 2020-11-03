using System;
using System.Collections.Generic;

namespace Game {

    class Program {

        static void Main(string[] args) {

            char player = '@';
            int x = 3;
            int y = 3;

            #region Map
            List<string> map = new List<string> { };
            map.Add("█████████████████████████████");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█                           █");
            map.Add("█████████████████████████████");

            foreach (string partOfMap in map) {
                Console.WriteLine(partOfMap);
            }
            #endregion

            while (true) {
                Console.Clear();
                foreach (string partOfMap in map) {
                    Console.WriteLine(partOfMap);
                }
                Console.SetCursorPosition(x, y);
                Console.OpenStandardOutput();
                Console.Write(player);
                ConsoleKeyInfo Input = Console.ReadKey();
                if (Input.KeyChar == 'w') y -= 1;
                if (Input.KeyChar == 'a') x -= 1;
                if (Input.KeyChar == 's') y += 1;
                if (Input.KeyChar == 'd') x += 1;
            }


        }
    }
}
