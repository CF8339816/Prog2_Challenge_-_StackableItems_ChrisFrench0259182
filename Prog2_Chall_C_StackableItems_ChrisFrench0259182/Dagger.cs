using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Chall_C_StackableItems_ChrisFrench0259182
{
   
   public class Dagger : Item

    {
        public Dagger(string Description, bool IsStackable, int Value) : base(Description, false, Value)
        {



        }

        public Dagger dagger = new Dagger("Dagger", false, 1);
    }
}
