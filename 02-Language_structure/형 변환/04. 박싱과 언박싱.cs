//using System;
//// 박싱과 언박싱
//// 박싱: 값형 데이터를 참조형으로 변환하는 것
//// 언박싱: 참조형을 값형으로 변환하는 것, 반드시 캐스팅을 통하여 이루어짐.

//// stack영역에 메모리가 생성되는 값형은 신속하게 그 데이터에 접근할 수 있는 반면,
//// heap영역에 메모리가 생성되는 참조형은 데이터의 관리 면에 있어 효율성을 지닌다.
//class BoxingUnboxingApp {
//    public static void Main() {
//        int foo = 526; // 원래형
//        object bar = foo; // 박싱: foo is boxed to bar.
//        Console.WriteLine(bar);
//        try {
//            double d = (short)bar;
//            // 잘못된 형식으로의 형 변환
//            // double d = (int)bar;
//            // Boxing 결과를 UnBoxing 시 원래 형으로 UnBoxing 필요
//            Console.WriteLine(d);
//        } catch (InvalidCastException e) {
//            Console.WriteLine(e + "예외처리입니다");
//        }
//    }
//}
