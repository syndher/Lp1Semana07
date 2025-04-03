using System;



namespace ColorSpheres
{

    public class Color(byte red, byte green, byte blue, byte alpha)
    {
        private byte _red = red;
        private byte _green = green;
        private byte _blue = blue;
        private byte _alpha = 255;

        public byte GetRed()
        {
            return _red;
        }
        
        public byte GetBlue()
        {
            return _blue;
        }
        public byte GetGreen()
        {
            return _green;
        }
        public byte GetAlpha()
        {
            return _alpha;
        }
        public byte GetGrey()
        {
            return (byte)((_red + _green + _blue) / 3);
        }
    }
}
