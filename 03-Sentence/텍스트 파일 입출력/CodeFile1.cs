//// 스트림: 파일을 읽고 쓸 때 데이터의 흐름
//// C# 에서는 파일을 읽고 쓰기 위해 스트림 전용 클래스에서 생성된 오브젝트를 사용.
//// [파일 스트림 오브젝트] (파일 스트림 클래스)

//// 출력 스트림(데이터를 써 넣음): Byte 단위 조작
//// 입력 스트림(데이터를 읽음): 문자 단위, 줄 단위 조작(Text File), 기본 자료형 단위 조작(Binary File)

//using System;
//using System.IO;
//namespace ConsoleApplication1 {
//    class Program {
//        static void Main(string[] args) {
//            using (FileStream fs = new FileStream(@"C:\Temp\vs.png", FileMode.Open)) {
//                int size = (int)fs.Length;
//                byte[] buff = new byte[size];
//                // 이미지를 10번에 걸쳐 나누어 읽음
//                for (int i = 0; i < 10; i++) {
//                    int n = fs.Read(buff, 0, size / 10);
//                    //....
//                    Console.WriteLine(n);
//                }
//            }
//        }
//    }
//}
