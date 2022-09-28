using System;
// 기본 자료형
class PrimitiveTypeApp {
    public static void Main() {
        // 숫자형 - 정수형(부호있는(signed) 정수형/부호없는(unsigned))/실수형
        // 문자형
        // 십진형
        // 부울형
        sbyte a = sbyte.MaxValue; // 8 bit = 1 byte
        byte a1 = byte.MaxValue;
        short b = short.MaxValue; // 16 bit = 2 byte
        ushort b1 = ushort.MaxValue;
        int c = int.MaxValue; // 32 bit = 4 byte
        uint c1 = int.MaxValue;
        long d = long.MaxValue; // 64 bit = 8 byte
        ulong d1 = ulong.MaxValue;
        float e = float.MaxValue; // 32 bit = 4 byte
        // ufloat은 없다...
        double f = double.MaxValue; // 64 bit = 8 byte 
        char g = char.MaxValue; // 16bit = 2 byte
        decimal h = decimal.MaxValue;
        bool i = true;
        Console.WriteLine("sbyte: " + a);
        Console.WriteLine("byte: " + a1);
        Console.WriteLine("short: " + b);
        Console.WriteLine("ushort: " + b1);
        Console.WriteLine("int: " + c);
        Console.WriteLine("uint: " + c1);
        Console.WriteLine("long: " + d);
        Console.WriteLine("ulong: " + d1);
        Console.WriteLine("flaot: " + e);
        Console.WriteLine("double: " + f);
        Console.WriteLine("char: " + g);
        Console.WriteLine("decimal: " + h);
        Console.WriteLine("bool: " + i);
    }
}