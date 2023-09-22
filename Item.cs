using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerGame2
{
    internal class Item
    {
        public int maxStack = 9999;
        public float damage = 0;
        public int itemID;
        public int pickaxe = 0;
        public int axe = 0;
        public int hammer = 0;
        public string name;
        public Item(int itemID, string name, float damage, int maxStack, int pickaxe, int axe, int hammer)
        {
            this.itemID = itemID;
            this.damage = damage;
            this.pickaxe = pickaxe;
            this.axe = axe;
            this.hammer = hammer;
            this.maxStack = maxStack;
            this.name = name;
        }

    }
}
