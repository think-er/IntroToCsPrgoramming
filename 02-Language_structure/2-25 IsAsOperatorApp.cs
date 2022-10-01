//using System;
//public class IsAsOperatorApp {
//    static void IsOperator(object obj) {
//        Console.WriteLine(obj + " is int: " + (obj is int));
//        Console.WriteLine(obj + " is string: " + (obj is string));
//    }
//    static void AsOperator(object obj) {
//        Console.WriteLine(obj + " as string == null: " + (obj as string == null));
//    }

//    public static void Main() {
//        IsOperator(10);
//        IsOperator("ABC");
//        AsOperator(10);
//        // 정수형 상수인 10을 string 형으로 변환할 수 없으므로 null이 되며,
//        // 따라서 null이므로 "True"를 출력한다.
//        AsOperator("ABC");
//        // 하지만 스트링 상수인 "ABC"를 string 형으로 변환할 수 있으므로
//        // "ABC" 값을 가지는 스트링 객체에 대한 참조가 되며, 따라서 null이 아니므로
//        // "False"를 출력한다.
//    }

//}