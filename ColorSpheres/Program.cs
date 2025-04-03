using System;



namespace ColorSpheres
{

    class Program
    {

        private static void Main(string[] args)
        {   
            Color sphereC = new Color(222, 142, 123, 100);
            Sphere sphere = new Sphere(4.0f, sphereC);

            sphere.Throw();
            sphere.Throw();
            sphere.Pop();

            Console.WriteLine($"The sphere has bounced {sphere.GetTimesThrown()} times,its color is {sphereC.GetGrey()}");



        }
    }
}
