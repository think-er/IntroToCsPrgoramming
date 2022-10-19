//using System;
//class BaseClass
//{
//    // 인자 없음
//    public void MethodA()
//    {
//        Console.WriteLine("In BaseClass ...");
//    }
//}
//class DerivedClass : BaseClass
//{
//    // 인자 없음
//    // 부모 클래스의 메소드 은폐 (숨기기)
//    new public void MethodA()
//    {
//        Console.WriteLine("In DerivedClass ... Overriding !!!");
//    }
//    // 인자 있음
//    public void MethodA(int i)
//    {
//        Console.WriteLine("In DerivedClass ... Overloading !!!");
//    }
//}

//class OverridingAndOverloadingApp
//{
//    public static void Main()
//    {
//        BaseClass obj1 = new BaseClass();
//        // Base Class 생성
//        DerivedClass obj2 = new DerivedClass();
//        // 파생 클래스 생성
//        obj1.MethodA();
//        obj2.MethodA();
//        obj2.MethodA(1);
//    }
//}