using System;



namespace ColorSpheres
{

    public class Color
    {
        byte _red;
        byte _green;
        byte _blue;
        byte _alpha;
    
        public Color(byte red, byte green, byte blue, byte alpha)
        {
        _red = red;
        _green = green;
        _blue = blue;
        _alpha = 255;
        }
        
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
        public byte GetMix()
        {
            return (byte)((_red + _green + _blue) / 3);
        }
    }
}
