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
        private int _size { get;  set; }
      
        protected Inventory(int Size)
        {
            Size = 4;
            _size = Size;
            _items = new InventorySlot[Size];   
           
        }

       



        public void AddItem()
        {          
           
            Console.ReadKey();



            switch(Item item)
            {
                case 1: item = Coin.coin;break;
                case 2: item = RestorePotion;break;
                case 3: item = WizardHat; break;
                case 4: item = Dagger.dagger; break;
                
            }


            for (int i = 0; i < _items.Length; i++)
            {

                _items[i] = item;
             

        public void RemoveItem()
        {


        }


    }
}
