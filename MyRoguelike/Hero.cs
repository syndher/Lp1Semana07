﻿using System;
using System.Xml.XPath;

namespace MyRoguelike
{

    public class Hero
    {
        
            private int _xp;
            private float _health;
            private float _Maxhp;
            private string _name;
            public string GetName => _name;
            public int Level => _xp;
            public float MaxHealth => _health;
            public int GetXp => _xp;
            

        public Hero(int xp, float health, string name)
        {
                _xp = xp;
                _health = health;
                _name = name;
                _Maxhp = 100;

        }
        public void XP(int xp)
        {
            if (xp > 0)
            {
                _xp += xp;
                _xp = 1 + _xp / 1000;
            }

        }

        public void MHealth(int _xp, float Maxhp)
        {
            Maxhp = 100 + (_xp - 1) * 20;
        }

        public void TakeDamage(float damage)
        {
            _health -= damage;
            _xp += (int)damage / 20;
        }

        public void Health(float health)
        {
            if (_health <= 0)
            {
                _health = 0;
            }
        }



    }   
}