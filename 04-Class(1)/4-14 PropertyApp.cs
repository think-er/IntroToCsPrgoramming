//using System;
//class Fraction {
//    private int numerator;
//    private int denominator;
//    // 프로퍼티
//    // 식별자 구분 소대문자
//    public int Numerator {
//        get { return numerator; }
//        set { numerator = value; }
//    }
//    public int Denominator {
//        get { return denominator; }
//        set { denominator = value; }
//    }
//    override public string ToString() {
//        return (numerator + "/" + denominator);
//    }
//}
//class PropertyApp {
//    public static void Main() {
//        Fraction f = new Fraction(); int i;
//        f.Numerator = 1; // invoke set-accessor in Numerator
//        i = f.Numerator + 1; // invoke get-accessor in Numerator
//        f.Denominator = i; // invoke set-accessor in Denominator
//        Console.WriteLine(f.ToString());
//    }
//}