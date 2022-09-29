//using System;
//class Fraction {
//    int numerator; // 분자 필드
//    int denominator; // 분모 필드
//    // 메소드 오버로딩
//    public Fraction() { // 디폴트 생성자
//        numerator = 0;
//        denominator = 1;
//    }
//    public Fraction(int n) { // 생성자
//        numerator = n;
//        denominator = 1;
//    }
//    public Fraction(int n, int d) { // 생성자
//        numerator = n;
//        denominator = d;
//    }
//    // ToString 메소드가 이미 부모 클래스에 있다. 
//    // 새롭게 덮어쓰기
//    // String 객체의 메소드
//    override public String ToString() { // 기존 ToString() 메소드를 override함
//        return (numerator + "/" + denominator);
//    }
//}
//class OverloadedConstructorApp {
//    public static void Main() {
//        Fraction f1 = new Fraction(), f2 = new Fraction(2), f3 = new Fraction(1, 2);
//        // Console.WriteLine("f1 = {0}, f2 = {1}, f3 = {2}",f1, f2, f3);
//        Console.WriteLine("f1 = {0}, f2 = {1}, f3 = {2}", f1.ToString(), f2.ToString(), f3.ToString());
//    }
//}