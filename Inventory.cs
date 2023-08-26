using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerGame2
{
    internal class Inventory
    {
        public Item[] stored;
        public Inventory(int slot)
        {
            stored = new Item[slot];
            for (int i = 0; i <= stored.Length; i++)
            {
                stored[i] = new Item(0 ,0 ,0 ,0 ,0, 0);
            }
        }
        public void Store(int itemID, int slot)
        {
            if (slot > stored.Length) return;
            stored[slot] = itemID;
        }
        public void remove(int slot)
        {
            stored[slot] = 0;
        }
    }
}
