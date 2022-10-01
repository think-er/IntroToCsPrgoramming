//using System;
//class NullableTypeApp {
//    public static void Main() {
//        // C#에서 값형은 초기값으로 0이 설정되고 참조형은 참조할 객체가 없음을
//        // 나타내는 null로 설정된다.
//        // 그러나 값형도 참조형과 같이 값이 없는 것을 나타낼 필요가 있는 경우
//        // 널이 가능한 형은 참조형과 같이 값이 없는 경우를 나타낼 때 사용하는 자료형으로
//        // 값형 자료형 다음에 ? 기호를 붙여서 정의한다.
//        double? num1 = null;
//        double? num2 = 10.0;

//        if (num1.HasValue)
//            Console.WriteLine("num1 = " + num1.Value);
//        else
//            Console.WriteLine("num1 doest not have value.");
//        if (num2.HasValue)
//            Console.WriteLine("num2 = " + num2.Value);
//        else
//            Console.WriteLine("num2 does not have value.");
//    }
//}