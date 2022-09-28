//using System;
//class ReadIntegerApp {
//    static int ReadInt() {
//        char ch;
//        int n = 0;
//        while (!char.IsDigit(ch = (char)Console.Read())) ;
//        // 문자로 바꾼 값이 '0'~'9'까지의 숫자 형태여야 한다.
//        do {
//            n = n * 10 + (ch - '0');
//            ch = (char)Console.Read();
//        } while (char.IsDigit(ch));
//        return n;
//    }
//    public static void Main() {
//        Console.Write("*** input data: ");
//        Console.WriteLine("*** read data: " + ReadInt() + " " + ReadInt());
//    }
//}