using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerGame2
{
    internal class Item
    {
        int maxStack = 9999;
        float damage = 0;
        int itemID;
        int pickaxe = 0;
        int axe = 0;
        int hammer = 0;
        string name;
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
