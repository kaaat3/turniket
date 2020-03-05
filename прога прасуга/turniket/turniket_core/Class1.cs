using System;

namespace turniket_core
{
    public interface ITurniket_API
    {
        bool Check_Enter(string barCode);
        bool Check_Out(string barCode); 



    }
}
