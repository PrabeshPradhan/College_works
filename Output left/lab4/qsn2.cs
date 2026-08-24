using System;

class Box {
    private double w, h, d;

    public Box(double w, double h, double d) { this.w = w; this.h = h; this.d = d; }

    public double findVolume() => w * h * d;
    public double findSurfaceArea() => 2 * (w*h + w*d + h*d);
}

class MyBox {
    static void Main() {
        Box b1 = new Box(2, 3, 4);
        Box b2 = new Box(5, 6, 7);

        Console.WriteLine("Box1 Volume: " + b1.findVolume());
        Console.WriteLine("Box1 Surface Area: " + b1.findSurfaceArea());

        Console.WriteLine("Box2 Volume: " + b2.findVolume());
        Console.WriteLine("Box2 Surface Area: " + b2.findSurfaceArea());
    }
}
