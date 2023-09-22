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
            for (int i = 0; i < slot; i++)
            {
                stored[i] = ID.item[0];
            }
        }
        public System.Boolean Store(int itemID, int slot)   // dont ask (stores an item)
        {
            if (slot < stored.Length)
            {
                stored[slot] = ID.item[itemID];
                return true;
            }
            return false;
        }
        public bool Remove(int slot)    // removes an item from the inventory
        {
            if (slot < stored.Length)
            {
                Store(ID.ItemID.nothing, slot);
                return true;
            }
            return false;
        }
        public void Clear()     // removes everything from the inventory
        {
            for (int i = 0;  i <= stored.Length; i++)
            {
                stored[i] = ID.item[ID.ItemID.nothing];
            }
        }
        public int NextFree()   // checks for the next free inventory slot, returns -1 if none
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
