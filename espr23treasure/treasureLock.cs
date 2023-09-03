using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace espr23treasure
{
    internal class treasureLock
    {
        public byte buttons = 0b0000;
        Random rnd = new Random();

        public void Randomise()
        {
            buttons = (byte)rnd.Next(0, 256);
        }

        public void Spin()
        {
            
        }

        public string ToString()
        {
            return Convert.ToString(buttons >> 4, 2).PadLeft(4, '0');
        }

        public void Press(byte toPress)
        {
            buttons = (byte)(buttons ^ toPress);
        }
    }
}
