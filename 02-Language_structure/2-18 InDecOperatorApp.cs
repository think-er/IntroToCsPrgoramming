//using System;
//// 증가 연산자와 감소 연산자
//// 전위 연산자와 후위 연산자
//// 연산 전에 x의 값 증가/감소: 전위 연산자
//// 연산 후에 x의 값 증가/감소: 후위 연산자

//// ++x; --x; 같은 연산자가 효율적
//// (1)x의 값을 메모리로부터 읽어 와서 (2)연산한 후에
//// (3)다시 결과 값을 x의 주소에 저장하는
//// 여러개의 명령어 필요 -> x =(3) (x(1) + 1)(2) 
//// 증감연산자는 단 하나의 명령어만으로 실행할 수 있기 때문이다.
//class InDecOperatorApp {
//    public static void Main() {
//        int x = 3, y = 5;
//        int a, b;
//        ++x; --y; // 4 4
//        Console.WriteLine("x = " + x + " , y = " + y);
//        a = (++x) + 1; // 6
//        Console.WriteLine("x = " + x + " , a = " + a);
//        b = (y++) + 1; // 5
//        Console.WriteLine("y = " + y + " , b = " + b);
//    }
//}