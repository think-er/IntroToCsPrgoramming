//using System;
//namespace CS_array_parameter {
//    class Program {
//        static void Main(string[] args) {
//            int[] val = new int[] { 100, 200, 300 };
//            // 배열의 주소를 넘김 : 배열 이름 => 참조형 변수
//            Push10(val);
//            Console.WriteLine("Val = {0} : {1} : {2}", val[0], val[1], val[2]);
//            Push100(ref val[1]);
//            // 배열 요소는 ref 
//            Console.WriteLine("Val[1] = {0}", val[1]);
//        }
//        static void Push10(int[] val) {
//            for (int i = 0; i < 3; i++) val[i] += 10;
//        }
//        static void Push100(ref int val) {
//            val += 100;
//        }
//    }
//}