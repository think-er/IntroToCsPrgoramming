//using System;
//using System.Text;

//// 직렬화(Serialization): 데이터, 객체 -> 바이트 배열로 변환 (데이터 보관)
//// byte = 8 bit 
////메모리를 디스크에 저장하거나
////네트워크 통신에 사용하기 위한 형식으로 변환하는 것을 말한다. 

//// https://limvo.tistory.com/7

//// 역직렬화(Deserialization): 바이트 배열 -> 데이터, 객체로 복원 (데이터 복원)
//// 그 반대로 디스크에 저장한 데이터를 읽거나, 
//// 네트워크 통신으로 받은 데이터를 메모리에 쓸 수 있도록 다시 변환하는 것이다. 


//class Change {
//    public static void Main() {
//        string str = "Hello World";
//        byte[] bytes = Encoding.ASCII.GetBytes(str);
//        // 바이트 스트림

//        Console.WriteLine("string: " + str);
//        Console.Write("byte array: ");
//        for (int i = 0; i < bytes.Length; i++) {
//            Console.Write("{0:x} ", bytes[i]);
//        }
//        Console.WriteLine("\n");



//        int n = 1652300;
//        string text = n.ToString();
//        // 숫자를 문자열로 직렬화
//        Console.WriteLine("string text: " + text);
//        int result = int.Parse(text);
//        Console.WriteLine("int result: " + result);
//        // 문자열로부터 숫자로 역직렬화
//        int result1 = Convert.ToInt32(text);
//        // 문자열로부터 숫자로 역직렬화
//        // 인자가 null일 경우, 0 반환
//        Console.WriteLine("int result1: " + result1);
//    }
//}