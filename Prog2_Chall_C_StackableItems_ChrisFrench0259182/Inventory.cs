using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Chall_C_StackableItems_ChrisFrench0259182
{
   public class Inventory
    {
              
        public InventorySlot[] _items;
        private int _size { get;  set; }

        protected Inventory(int Size)
        {
            Size = 4;
            _size = Size;

            

        }


    }
}
