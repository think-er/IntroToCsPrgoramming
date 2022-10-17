//using System;

//// C#에서 int, float 등 기본 자료형은 모두 struct로 만들어진다.
//// C#에서 기본 자료형(int 등)은 내부적으로 모두 구조체(필드 + 메소드 + 프로퍼티)로 정의된다.
//// 구조체: 값형

//// 구조체의 각 멤버는 접근제한자가 생략되는 경우, default로 private이 된다.

//// 인자가 있는 생성자나 static 생성자만 사용자 정의 생성자로 정의 가능

//public struct Point
//{
//    public int x;
//    public int y;
//    // public Point() { } 생성자(오류) <- 기본생성자: 사용불가(초기화 가능한 생성자 사용)

//    public Point(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }
//}

//class Structure
//{
//    static void Main(string[] args)
//    {
//        // new를 사용한 생성자 호출
//        // heap 이 아닌 stack 공간에 생성, new의 의미가 항상 참조형을 의미하진 않는다(C#)
//        // new는 data형에 대한 기본 생성자 사용 의미이다.
//        Point p = new Point(30, 70);
//        Console.WriteLine("I am still at stack");
//        Console.WriteLine($"Point.x = {p.x}, Point.y = {p.y}");
//        // new 연산자 없이 객체를 생성하면, 모든 멤버를 초기화해야한다.
//        // 멤버 사용(참조) 전에 초기화 필요
//        Point s;
//        s.x = 30;
//        s.y = -49;
//        Console.WriteLine("I am at stack too");
//        Console.WriteLine($"Point.x = {s.x}, Point.y = {s.y}");
//    }
//}