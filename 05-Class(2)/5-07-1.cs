//using System;
//class BaseClass
//{
//    virtual public void MethodA()
//    // public void MethodA()
//    {
//        Console.WriteLine("do BaseClass Task.");
//    }
//}//class DerivedClass : BaseClass
//{
//    // new public void MethodA()
//    // 재정의하는 키워드로, override를 사용할 경우, base 클래스의 대응하는 메소드는
//    // virtual 키워드 필수
//    override public void MethodA()
//    {
//        base.MethodA(); // 부모 클래스의 Method A()호출
//        Console.WriteLine("do DerivedClass Task.");
//    }
//}