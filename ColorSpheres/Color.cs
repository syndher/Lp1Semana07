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
    }
}
