using System;
using System.Collections.Generic;
using System.Text;

namespace constReadonly
{
    class Generic_Class <T> where T : Electronic
    {
       public int ReturnRam(T ram) 
        
        {
            return ram.Ram;
        }
    }
}
