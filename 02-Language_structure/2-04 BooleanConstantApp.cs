using System;
class BooleanConstantApp {
    public static void Main() {
        Console.WriteLine("TRUE OR TRUE = " + (true || true));
        Console.WriteLine("TRUE OR FALSE = " + (true || false));
        Console.WriteLine("FALSE OR TRUE = " + (false || true));
        Console.WriteLine("FALSE OR FALSE = " + (false || false));
    }
}