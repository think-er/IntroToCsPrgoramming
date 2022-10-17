//using System;
//// 클래스와 동일하게 객체의 구조와 행위를 정의하는 방법
//// 클래스: 참조(Reference)형 / 구조체: 값(Value)형(스택 영역에 저장)
//// 구조체는 여러개의 필드로 구성된 자료 구조를 표현하기 위해 주로 사용
//// [struct-modifiers] struce StructName
//struct Point
//{
//    public int x, y;
//    public Point(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }
//    public override string ToString()
//    {
//        return "(" + x + ", " + y + ")";
//    }
//}

//class StructApp
//{
//    public static void Main()
//    {
//        Point[] pts = new Point[3];
//        pts[0] = new Point(100, 100);
//        pts[1] = new Point(100, 200);
//        pts[2] = new Point(200, 200);
//        foreach (Point pt in pts)
//            Console.WriteLine(pt);
//    }
//}