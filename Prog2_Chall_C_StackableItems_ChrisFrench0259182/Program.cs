using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Chall_C_StackableItems_ChrisFrench0259182
{
   public class Program
   {

        public List<Inventory> inventories = new List<Inventory>();
       public static void Main()

       {

            //inventories.Add(Inventory myInventory = new Inventory(4));
            //inventories.Add(Inventory friendInventory = new Inventory(4));
            Inventory myInventory = new Inventory(4);
            Inventory friendInventory = new Inventory(4);
            bool running = true;

            while (running)
            { 
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
               // Console.SetCursorPosition(1, 2);
                Console.WriteLine("\n[1-4] Add: Coin, Restore Potion, Wizard Hat, Dagger \n");
               // Console.SetCursorPosition(1, 3);
                Console.WriteLine("| [Q-R] Remove Slot 1-4 | [T] to Trade an item to Friend inventory |[X] Exit\n\n");
               

                 Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("~~~~~ MY INVENTORY SYSTEM ~~~~~");
                for (int i = 0; i < myInventory._items.Length; i++)
                {
                    var slot = myInventory._items[i];
                    string info = slot._item == null ? "Empty" : slot._item._description;
                    string count = (slot._item != null && slot._item._isStackable) ? $" (x{slot._amount})" : "";

                   
                    //Console.SetCursorPosition(1, 5+ i++);

                    Console.WriteLine($"Slot {i + 1}: {info}{count}");
                }
                Console.WriteLine("\n\n\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
               // Console.SetCursorPosition(60, 2);
                Console.WriteLine("\n[7-0] Add: Coin, Restore Potion, Wizard Hat, Dagger \n");
               // Console.SetCursorPosition(60, 3);
                Console.WriteLine("| [U-P] Remove Slot 1-4 | [Y] to Yeet an item at My inventory | [M] Exit\n\n");
               


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("~~~~~ FRIEND INVENTORY SYSTEM ~~~~~");
                for (int i = 0; i < friendInventory._items.Length; i++)
                {
                    var slot = friendInventory._items[i];
                    string info = slot._item == null ? "Empty" : slot._item._description;
                    string count = (slot._item != null && slot._item._isStackable) ? $" (x{slot._amount})" : "";

                  
                   // Console.SetCursorPosition(60, 5 + i++);

                    Console.WriteLine($"Slot {i + 1}: {info}{count}");
                }

                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1: myInventory.AddItem(new Coin()); break;
                    case ConsoleKey.D2: myInventory.AddItem(new RestorePotion()); break;
                    case ConsoleKey.D3: myInventory.AddItem(new WizardHat()); break;
                    case ConsoleKey.D4: myInventory.AddItem(new Dagger()); break;
                    case ConsoleKey.Q: myInventory.RemoveItem(0); break;
                    case ConsoleKey.W: myInventory.RemoveItem(1); break;
                    case ConsoleKey.E: myInventory.RemoveItem(2); break;
                    case ConsoleKey.R: myInventory.RemoveItem(3); break;
                   //case ConsoleKey.T: myInventory.TradeItem(heldItem); break;
                    case ConsoleKey.X: running = false; break;

                    case ConsoleKey.D7: friendInventory.AddItem(new Coin()); break;
                    case ConsoleKey.D8: friendInventory.AddItem(new RestorePotion()); break;
                    case ConsoleKey.D9: friendInventory.AddItem(new WizardHat()); break;
                    case ConsoleKey.D0: friendInventory.AddItem(new Dagger()); break;
                    case ConsoleKey.U: friendInventory.RemoveItem(0); break;
                    case ConsoleKey.I: friendInventory.RemoveItem(1); break;
                    case ConsoleKey.O: friendInventory.RemoveItem(2); break;
                    case ConsoleKey.P: friendInventory.RemoveItem(3); break;
                     //case ConsoleKey.Y: myInventory.TradeItem(heldItem); break;
                    case ConsoleKey.M: running = false; break;


                }


            }
        }
    
   }
}
