//// 생성자 호출 순서
//using System;
//class BaseClass
//{
//    // 기본 생성자
//    // 3. 파생 클래스의 생성자 실행
//    public BaseClass()
//    {
//        Console.WriteLine("BaseClass Constructor ...");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public DerivedClass()
//    // public DerivedClass() : base() { ... } 
//    // base() <- 컴파일러가 자동으로 포함
//    // 2. 베이스 클래스의 생성자 실행
//    {
//        Console.WriteLine("DerivedClass Constructor ...");
//    }
//}

//class DerivedConstructorApp
//{
//    public static void Main()
//    {
//        DerivedClass obj = new DerivedClass();
//        // 1. 필드(존재 시) 초기화 부분 실행
//        Console.WriteLine("in main ...");
//    }
//}