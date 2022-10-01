//using System;
//class LogicalOperatorApp {
//    public static void Main() {
//        int x = 3, y = 5, z = 7;
//        bool b;
//        b = x < y && y < z; // (3 < 5)(5 < 7) True*True => True
//        Console.WriteLine("Result = " + b);
//        b = x == y || x < y && y > z;
//        // 논리부정 -> 논리곱 -> 논리합 순으로 우선순위가 가장 높다.(내림차순)
//        // (3 == 5) || (3 < 5) && (5 > 7) False || True && False
//        // False || False => False
//        Console.WriteLine("Result = " + b);
//    }
//}