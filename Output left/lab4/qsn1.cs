using System;

class Circle {
    private float radius;

    public Circle(float r) { radius = r; }

    public double findArea() => Math.PI * radius * radius;
    public double findCircumference() => 2 * Math.PI * radius;
}

class MyCircle {
    static void Main() {
        float r = float.Parse(Console.ReadLine());
        Circle c = new Circle(r);

        Console.WriteLine("Area: " + c.findArea());
        Console.WriteLine("Circumference: " + c.findCircumference());
    }
}
