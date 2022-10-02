//using System;
//// System.BitConverter 클래스를 통해서 리터럴 타입의 변수 (int, long 등)의 값을
//// byte[] 바이트로 변환한 값을 얻을 수 있다.
//class Program {
//    static void Main(string[] args) {
//        // 기본 자료형을 바이트 배열로 변환 (little-endian 형식 )
//        byte[] boolBytes = BitConverter.GetBytes(true);
//        // true와 false는 1바이트(8-비트)로 저장
//        byte[] shortBytes = BitConverter.GetBytes((short)32000);
//        // short(16비트)
//        // 2진수: 0111 | 1101 | 0000 | 0000
//        // 16진수: 0x7D | 0x00
//        // 출력은 LSB -> MSB 순으로 출력
//        byte[] intBytes = BitConverter.GetBytes(1652300);
//        // 2진수 : 0000 | 0000 | 0001 | 1001 | 0011 | 0110 | 0100 | 1100
//        // 16진수 : 0x00 0x19 0x36 0x4C
//        // 바이트 배열을 원래 기본 형으로 복원
//        bool boolResult = BitConverter.ToBoolean(boolBytes, 0);
//        short shortResult = BitConverter.ToInt16(shortBytes, 0);
//        int intResult = BitConverter.ToInt32(intBytes, 0);
//        // 바이트 배열을 16진수 문자열로 출력 (little-endian 형식 )

//        Console.WriteLine(BitConverter.ToString(boolBytes));
//        Console.WriteLine(BitConverter.ToString(shortBytes));
//        Console.WriteLine(BitConverter.ToString(intBytes));
//        // 보통의 타입 ( int, short, float.. 등 ) 에서는
//        // 그 타입의 변수가 가지고 있는 값을 반환한다.
//        // 배열을 문자열로 만든다.

//        Console.WriteLine(boolResult);
//        Console.WriteLine(shortResult);
//        Console.WriteLine(intResult);
//    }
//}