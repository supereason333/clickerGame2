using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerGame2
{
    internal static class ID
    {
        public static Item[] item =
        {
            new Item(0, "nothing", 0, 0, 0, 0, 0),
            new Item(1, "Wood", 0, 9999, 0, 0, 0),
            new Item(2, "Copper Shortsword", 10, 1, 0, 0, 0),
            new Item(3, "Copper Axe", 3, 1, 0, 20, 0),
            new Item(4, "Copper Pickaxe", 3, 1, 20, 0, 0),
            new Item(5, "Workbench", 0, 9999, 0, 0, 0)
        };
        public static class ItemID
        {
            public static int nothing = 0;
            public static int wood = 1;
            public static int copperShortsword = 2;
            public static int copperAxe = 3;
            public static int copperPickaxe = 4;
            public static int workbench = 5;
        }
    }
}
