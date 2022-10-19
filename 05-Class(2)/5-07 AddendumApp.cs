//using System;
//class BaseClass
//{
//    // new로 재정의할 경우, base 클래스의 메소드는 virtual 키워드가 선택적
//    public void MethodA()
//    {
//        Console.WriteLine("do BaseClass Task.");
//    }
//}
//class DerivedClass : BaseClass
//{
//    // base 클래스의 메소드 은폐
//    new public void MethodA()
//    {
//        base.MethodA(); // 부모 클래스의 Method A()호출
//        Console.WriteLine("do DerivedClass Task.");
//    }
//}//class AddendumApp
//{
//    public static void Main()
//    {
//        DerivedClass obj = new DerivedClass();
//        obj.MethodA();
//        // DerivedClass의 MethodA() 호출
//    }
//}