using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Chall_C_StackableItems_ChrisFrench0259182
{
    public class Inventory
    {

        public InventorySlot[] _items;
        private int _size { get; set; }
        //public Item heldItem;
        public Inventory(int Size)
        {

            _size = Size;
            //_items[i] = new InventorySlot[Size];   
            _items = new InventorySlot[Size];
            //Size = 4;


            for (int i = 0; i < Size; i++)
            {

                // _items[i] = item;
                _items[i] = new InventorySlot();



            }
        }


        public bool AddItem(Item item)
        {

            if (item._isStackable)
            {
                foreach (var slot in _items)
                {
                    // if (slot._item != null && slot._item._description == item._description)
                    if (slot._item != null && slot._item.GetType() == item.GetType())
                    {
                        slot._amount++;
                        // return (_items[_size] = true);
                        return true;
                    }
                }
            }



            foreach (var slot in _items)
            {
                if (slot._item == null)
                {
                    slot._item = item;
                    slot._amount = 1;
                    return true;
                }
            }
            return false;
        }



        public void RemoveItem(int index)
        {
            if (index < 0 || index >= _items.Length || _items[index]._item == null) return;

            if (_items[index]._item._isStackable && _items[index]._amount > 1)
            {
                _items[index]._amount--;
            }
            else
            {
                _items[index]._item = null;
                _items[index]._amount = 0;
            }
        }

        //public void TradeItem(int index, Item heldItem)
        //{
        //    if (index < 0 || index >= _items.Length || _items[index]._item == null) return;

        //    heldItem = _items[index]._item;

        //    if (_items[index]._item._isStackable && _items[index]._amount > 1)
        //    {
        //        Console.WriteLine($"How many {heldItem} do you want to trade?");
        //        int amount = Convert.ToInt32(Console.ReadLine());
        //        if (amount > _items[index]._amount)
        //        {
        //            amount = _items[index]._amount;

        //            // _items[index]._amount;



        //            _items[index]._amount--;
        //        }
        //        else
        //        {
        //            _items[index]._item = null;
        //            _items[index]._amount = 0;
        //        }
        //    }

            //    AddToOtherInventory(heldItem);
            //}
            //public bool AddToOtherInventory(Item heldItem)
            //{ 
            //foreach (Inventory other in Program.Main())
            //{
            //    if (heldItem._isStackable)
            //    {

            //        foreach (var slot in _items)
            //        {
            //            // if (slot._item != null && slot._item._description == item._description)
            //            if (slot._item != null && slot._item.GetType() == heldItem.GetType())
            //            {
            //                slot._amount++;
            //                // return (_items[_size] = true);
            //                return; //true;
            //            }
            //            if (slot._item == null)
            //            {
            //                slot._item = heldItem;
            //                slot._amount = 1;
            //                return; //true;
            //            }
            //        }
            //        return; //false;
            //    }
            //}
        }


        













    }

