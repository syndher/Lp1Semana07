using System;



namespace ColorSpheres
{

    public class Sphere
    {
        float _radius;
        readonly Color color;
        int _bounces;
    
        public Sphere(float radius, Color color)
        {
            _radius = radius;
            this.color = color;
            _bounces = 0;
        }
        public void Pop()
        {
            _radius = 0;
        }
        public void Throw()
        {
            if (_radius > 0)
            {
                _bounces++;
            }

        }
        public int GetTimesThrown()
        {
            return _bounces;
        }
    }   
}