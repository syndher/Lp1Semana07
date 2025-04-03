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
    }   
}