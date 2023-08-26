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
        }
        public System.Boolean Store(int itemID, int slot)   // dont ask
        {
            if (slot <= stored.Length)
            {
                stored[slot] = ID.item[itemID];
                return true;
            }
            return false;
        }
        public void Remove(int slot)
        {
            Store(ID.ItemID.nothing, slot);
        }
        public void Clear()
        {
            for (int i = 0;  i <= stored.Length; i++)
            {
                stored[i] = ID.item[ID.ItemID.nothing];
            }
        }
        public int NextFree()
        {
            for (int i = 0; i <= stored.Length; i++)
            {
                if (stored[i] == ID.item[ID.ItemID.nothing])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
