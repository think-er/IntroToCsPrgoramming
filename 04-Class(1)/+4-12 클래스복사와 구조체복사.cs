//using System;

//// 구조체는 상속이 불가능하다.
//// 구조체의 멤버는 초기값을 가질 수 없다.
//// 구조체의 멤버필드는 선언과 동시에 초기화 불가능
//// 생성자 존재시 생성자에서 초기화

//class Program
//{
//    class PointClass
//    {
//        public int x;
//        public int y;

//        public PointClass(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    struct PointStruct
//    {
//        public int x;
//        // public int x = 100; 오류
//        public int y;

//        public PointStruct(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    static void Main(string[] args)
//    {
//        // 클래스
//        PointClass pointClassA = new PointClass(10, 20);
//        PointClass pointClassB = pointClassA; // 참조 복사 (얕은 복사)

//        pointClassB.x = 100;
//        pointClassB.y = 100;

//        Console.WriteLine("pointClassA :" + pointClassA.x + "," + pointClassA.y);
//        Console.WriteLine("pointClassB :" + pointClassB.x + "," + pointClassB.y);

//        // 구조체
//        PointStruct pointStructA = new PointStruct(10, 20);
//        PointStruct pointStructB = pointStructA; // 값 복사 (깊은 복사) 

//        pointStructB.x = 100;
//        pointStructB.y = 200;

//        Console.WriteLine("pointStructA :" + pointStructA.x + "," + pointStructA.y);
//        Console.WriteLine("pointStructB :" + pointStructB.x + "," + pointStructB.y);
//    }
//}