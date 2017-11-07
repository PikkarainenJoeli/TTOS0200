using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    class Teht4
    {
        class Shapes
        {
            public List<Shape> ShapesList = new List<Shape>();

            public Shapes()
            {
                ShapesList.Add();
            }
        }

        abstract class Shape
        {
            public string Name { get; }
            public int Radius { get; set; }
            public abstract void area(int Radius);
            public abstract void area(int Width, int Height);
            public abstract void circumference(int radius);
            public abstract void circumference(int Width, int Height);



        }

         class Circle : Shape
        {
            
            public double Circfer { get; set; }
            public double Area { get; set; }

            public override void area(int radius)
            {
                Area = Math.PI * radius * Math.Exp(2);              
            }

            public override void area(int Width, int Height)
            {
                throw new NotImplementedException();
            }

            public override void circumference(int radius)
            {
                Circfer = Math.PI * radius;
            }

            public override void circumference(int Width, int Height)
            {
                throw new NotImplementedException();
            }

        }

        class Square : Shape
        {

            public double Circfer { get; set; }
            public double Area { get; set; }


            public override void area(int Radius)
            {
                throw new NotImplementedException();
            }

            public override void area(int Width, int Height)
            {
                Area = Width * Height;
            }

            public override void circumference(int radius)
            {
                throw new NotImplementedException();
            }

            public override void circumference(int Width, int Height)
            {
                Circfer = (Width * 2) + (Height * 2);
            }

        }

        public static void ShapesMain()
        {
            try
            {
                Shape circle1 = new Circle();
                Shape circle2 = new Circle();
                Shape circle3 = new Circle();
                circle1.area(5);
                circle2.area(10);
                circle3.area(15);

                Shape square1 = new Square();
                Shape square2 = new Square();
                Shape square3 = new Square();
                square1.area(5);
                square2.area(10);
                square3.area(15);

                foreach (Shape item in )
                {

                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            

        }

    }
}
