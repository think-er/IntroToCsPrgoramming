//using System;

//// Boxing/UnBoxing 과정
//// object a = 123;
//// object 참조형 = 값형;

//// 모든 상황에서 object 타입 변수를 선언하는 것이 편해 보일 수 있지만
//// 이는 메모리 공간 낭비와 오류를 유발하기 쉬우므로, 각 상황에 맞는 타입을 선택해서
//// 사용하는 것이 좋다.



//namespace Object {
//    class Program {
//        static void Main() {
//            object a = 123;
//            object b = 3.141592653589793238462643383279m;
//            object c = true;
//            object d = "안녕하세요";
//            // 어떻게 이런 일이 가능한걸까???!!
//            // object 형식은 참조 형식이면서 값 형식(?)이다.
//            // 데이터와 참조 형식의 데이터 모두를 담을 수 있다.

//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//            Console.WriteLine(d);
//        }
//    }
//}