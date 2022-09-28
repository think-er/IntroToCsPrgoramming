using System;

class IntTypeApp {
    public static void Main() {
        int i = 1000000;
        Console.WriteLine(i * i);
        // Overflow 발생
        long l = i;
        Console.WriteLine(l * l);
    }
}