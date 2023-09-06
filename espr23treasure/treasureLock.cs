using System.Diagnostics.CodeAnalysis;
using System.Net.Mime;
using Convert = System.Convert;

namespace espr23treasure
{
    internal class TreasureLock
    {
        private byte _buttons;  //four most significant bits should remain zero throughout the program
        private readonly Random _rnd = new Random();

        public void Randomise()
        {
            _buttons = (byte)_rnd.Next(0, 16);  //four least significant bits get randomised
            Console.WriteLine(ToString());
            Check();
        }

        public void Spin()
        {
            var b = (byte)(_buttons + (_buttons << 4));     //1101 -> 1101 1101
            b = (byte)((b >> _rnd.Next(0, 4)) & 0b1111);    //1101 1101 -> 0011 0111 -> 0000 0111
            _buttons = b;
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            //Outputs _buttons in base 2 and adds '0' to the beginning to set length to 4 digits
            return Convert.ToString(_buttons, 2).PadLeft(4, '0');
        }

        public void Press(byte toPress, bool flip = true)
        {
            _buttons = (byte)(_buttons ^ toPress);
            Check();
            Console.WriteLine(ToString());
            if (flip)   //automatically checks to accomodate the possibility of all buttons being 0
            {
                Press(0b1111, false);
            }
            Spin();
        }

        public void Check()
        {
            if (_buttons != 0b1111) return;
            Console.WriteLine("Solved");
            Environment.Exit(0);
        }
    }
}
