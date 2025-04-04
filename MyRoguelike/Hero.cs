using System;
using System.Xml.XPath;

namespace MyRoguelike
{

    public class Hero
    {
        
            private int _xp;
            private float _health;
            public string GetName => _name;
            public int Level => 1 + _xp / 1000;

        public Hero(int xp)
        {
                _xp = xp;
                _health = _health;
                

        }
        public int XP(int xp)
        {
            if (xp > 0)
            {
                _xp += xp;
            }
            return _xp;

        }
    }
}