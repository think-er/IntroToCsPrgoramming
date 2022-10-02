//using System;
//// 메소드 내에서 변수를 선언할 때는 메소드 밖의 변수 이름과 같아도 괜찮다.
//// 같은 이름을 갖는 두 개의 변수가 메소드 안과 밖에서 사용된 경우
//class LocalVariableApp {
//    static int x;
//    public static void Main() {
//        int x = (LocalVariableApp.x = 2) * 2;
//        Console.WriteLine("static x = " + LocalVariableApp.x);
//        Console.WriteLine("local x = " + x);
//    }
//}