using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clip board");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }

    }


    var list of Shapes = new List<Shape>
new Circle ( Colour = "Red", Radius = 2.5 }, new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0).
new Circle { Colour = "Green", Radius = 8.0),
new Circle { Colour = "Purple", Radius = 12.3).
new Rectangle ( Colour = "Blue", Height = 45.0, Width = 18.0
)
};
}