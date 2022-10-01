//using System;
//// 관계연산자
//class RelationalOperatorsApp {
//    public static void Main() {
//        int x = 3, y = 5, z = 7;
//        bool b1, b2;
//        b1 = x > y; // 3 > 5 False
//        b2 = x < y && y < z; // (3 < 5)(5 < 7) true*true => True
//        Console.WriteLine("b1 = " + b1 + ", b2 = " + b2);
//        b1 = x <= y; // 3 <= 5 True
//        b2 = x >= y == y >= x; // (3 >= 5) == (5 >= 3) False=True => False
//        Console.WriteLine("b1 = " + b1 + ", b2 = " + b2);
//        // 항등 연산자보다 비교 연산자의 우선순위가 더 높다. (먼저 계산됨)
//    }
//}