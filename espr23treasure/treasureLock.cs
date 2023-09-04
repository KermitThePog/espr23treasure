using System.Net.Mime;

namespace espr23treasure
{
    internal class TreasureLock
    {
        private byte _buttons;
        private readonly Random _rnd = new Random();

        public void Randomise()
        {
            _buttons = (byte)_rnd.Next(0, 16);
            Console.WriteLine(ToString());
            Check();
        }

        public void Spin()
        {
            
        }

        public override string ToString()
        {
            return Convert.ToString(_buttons, 2).PadLeft(4, '0');
        }

        public void Press(byte toPress, bool flip = true)
        {
            _buttons = (byte)(_buttons ^ toPress);
            Check();
            Console.WriteLine(ToString());
            if (flip)
            {
                Press(0b1111, false);
            }
        }

        public void Check()
        {
            if (_buttons != 0b1111) return;
            Console.WriteLine("Solved");
            Environment.Exit(0);
        }
    }
}
