using System;



namespace ColorSpheres
{

    public class Color
    {
        private byte _red;
        private byte _green;
        private byte _blue;
        private byte _alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            byte _red = red;
            byte _green = green;
            byte _blue = blue;
            byte _alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = 255;
        }
        public byte GetRed => _red;
        public byte GetGreen => _green;
        public byte GetBlue => _blue;
        public byte GetAlpha => _alpha;

        public byte GetGrey => (byte)((_red + _green + _blue) / 3);

    }
}
