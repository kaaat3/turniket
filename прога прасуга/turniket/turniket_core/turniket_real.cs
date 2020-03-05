using System;
using System.Collections.Generic;
using System.Text;

namespace turniket_core
{
    class turniket_real : ITurniket_API
    {
        public bool Check_Enter(string barCode)
        {
            throw new NotImplementedException();
            if (barCode == "1234")
                return true;
            else
                return false;
        }

        public bool Check_Out(string barCode)
        {
            throw new NotImplementedException();
            if (barCode == "1234")
                return true;
            else
                return false;
        }
    }
}
