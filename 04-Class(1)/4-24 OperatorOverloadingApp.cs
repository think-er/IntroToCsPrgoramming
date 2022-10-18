//using System;
//class Complex
//{
//    private double realPart;
//    private double imagePart;
//    public Complex(double rVal, double iVal)
//    {
//        realPart = rVal;
//        imagePart = iVal;
//    }
//    // modifier는 반드시 public static 이다. 클래스의 정적 메소드로 정의
//    // 반환형은 연산자가 계산된 결과의 자료형
//    // 지정어 operator 사용, 연산자 기호로는 특수문자 사용
//    // modifier + returnType + operator
//    public static Complex operator +(Complex x1, Complex x2)
//    {
//        Complex x = new Complex(0, 0);
//        x.realPart = x1.realPart + x2.realPart;
//        x.imagePart = x1.imagePart + x2.imagePart;
//        return x;
//    }
//    public override string ToString()
//    {
//        return "(" + realPart + ", " + imagePart + "i)";
//    }
//}

//class OperatorOverloadingApp
//{
//    public static void Main()
//    {
//        Complex c, c1, c2;
//        c1 = new Complex(1, 2);
//        c2 = new Complex(3, 4);
//        c = c1 + c2;
//        Console.WriteLine(c1 + " + " + c2 + " = " + c);
//        // c.ToString() 등가
//    }
//}