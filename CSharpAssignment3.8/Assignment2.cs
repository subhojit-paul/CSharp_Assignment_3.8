using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignment1
{
    interface IVolume
    {
        double Volume { get; }
    }
    interface IArea
    {
        double SurfaceArea();
    }

    interface ISolid : IArea, IVolume
    {

    }
    abstract class Solid : ISolid
    {
        double radius;
        const double pi = 3.142;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double Pi
        {
            get { return pi; }

        }

        public Solid()
        {

        }
        public Solid(double _radius, double _pi)

        {
            radius = _radius;

        }
        // double IVolume.Volume => throw new NotImplementedException();
        public abstract double Volume
        {
            get;
        }

        //double IArea.SurfaceArea()
        //{
        //    throw new NotImplementedException();
        //}
        public abstract double SurfaceArea();



    }
    class Cylinder : Solid
    {
        double height;
        // double Volume;
        public Cylinder()
        {

        }
        public Cylinder(double _height, double _radius, double _pi) : base(_radius, _pi)
        {
            height = _height;

        }

        public override double Volume
        {
            get
            {
                double volume = Pi * Radius * height;
                return volume;
            }

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 2 * Pi * Radius * (Radius + height);
            return surfaceArea;
        }
    }
    class Sphere : Solid
    {
        public Sphere()
        {

        }
        public Sphere(double _radius, double _pi) : base(_radius, _pi)
        {

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 4 / 3 * Pi * Radius * Radius * Radius;
            return surfaceArea;
        }
        public override double Volume
        {
            get
            {
                double volume = 4 * Pi * Radius * Radius;

                return volume;
            }

        }
    }
    class Assignment2
    {
        static void Main()
        {
            Cylinder cd = new Cylinder(5.6, 3.2, 3.14);
            //cd.SurfaceArea();
            Console.WriteLine("Volume of Cylinder : {0}", cd.Volume);
            Console.WriteLine("Surface area  of Cylinder:{0}", cd.SurfaceArea());
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            Sphere Sp = new Sphere(3.2, 3.14);
            Console.WriteLine(" Volume of Sphere :{0}", Sp.Volume);
            Console.WriteLine("Surface area of Sphere : {0}", Sp.SurfaceArea());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.Read();

        }
    }
}