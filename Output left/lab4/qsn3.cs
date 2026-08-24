using System;

class Distance {
    private int feet, inches;

    public Distance(int f, int i) { feet = f; inches = i; }

    private void fix() {
        feet += inches / 12;
        inches = inches % 12;
    }

    public Distance addDistance(Distance d) {
        Distance x = new Distance(feet + d.feet, inches + d.inches);
        x.fix();
        return x;
    }

    public void displayDistance() {
        Console.WriteLine(feet + " ft " + inches + " in");
    }
}

class MyDistance {
    static void Main() {
        Distance d1 = new Distance(3, 10);
        Distance d2 = new Distance(2, 8);

        Distance sum = d1.addDistance(d2);

        d1.displayDistance();
        d2.displayDistance();
        sum.displayDistance();
    }
}
