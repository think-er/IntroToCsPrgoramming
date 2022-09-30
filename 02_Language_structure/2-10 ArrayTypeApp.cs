//using System;
//class ArrayTypeApp {
//    public static void Main() {
//        int[] ia = new int[3];
//        int[] ib = { 1, 2, 3 };
//        // 배열 선언과 초기화 부분
//        // int[] ib = new int[] {1, 2, 3} 과 같은 의미이다.

//        // 이렇게는 안됨
//        // ---------------------
//        // int[] ib; (x)
//        // ib = { 1, 2, 3 }; (x)
//        // ---------------------
//        int i;
//        for (i = 0; i < ia.Length; i++)
//            // Length 프로퍼티
//            ia[i] = ib[i];
//        for (i = 0; i < ia.Length; i++)
//            Console.Write(ia[i] + " ");
//        Console.WriteLine();
//    }
//}