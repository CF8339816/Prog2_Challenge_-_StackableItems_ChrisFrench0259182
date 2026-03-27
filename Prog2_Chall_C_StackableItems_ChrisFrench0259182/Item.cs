using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Chall_C_StackableItems_ChrisFrench0259182
{
    public class Item
    {
        public string _description { get; set; }
        public bool _isStackable {  get; set; }    
        public int _value { get; set; }

        protected Item(string Description, bool IsStackable, int Value )
        {

            _description = Description;
            _isStackable = IsStackable;
            _value = Value;

        }



    }
}
