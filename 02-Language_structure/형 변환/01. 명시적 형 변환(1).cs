//using System;
//// 명시적 형 변환
//// 프로그래머가 캐스트 연산자를 사용하여 형을 변환하는 방법

//// 큰 수의 int 형에서 float 형으로 형 변환이 일어나면, float의 유효자리 수가 초과되어
//// 정밀도(precision)를 잃게 된다. 그러나 실행시간 예외가 발생하지는 않는다.
//class LosePrecisionApp {
//    public static void Main() {
//        int big = 1234567890;
//        float approx;
//        approx = (float)big;
//        Console.WriteLine("difference = " + (big - (int)approx));
//    }
//}