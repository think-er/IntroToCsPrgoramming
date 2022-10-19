//// 베이스 클래스에 있는 메소드에 작업을 추가하여, 새로운 기능을 갖는 메소드 정의
//// - base 지정어를 사용하여 베이스 클래스에 있는 메소드를 호출 가능

//using System;
//abstract class AbstractClass
//{
//    public abstract void MethodA();
//    public void MethodB()
//    {
//        Console.WriteLine("Implementation of MethodB()");
//    }
//}

//class ImpClass : AbstractClass
//{
//    // override 키워드
//    // 접근 수정자를 베이스클래스와 일치
//    public override void MethodA()
//    {
//        Console.WriteLine("Implementation of MethodA()");
//    }
//}

//class AbstractClassApp
//{
//    public static void Main()
//    {
//        ImpClass obj = new ImpClass();
//        obj.MethodA();
//        obj.MethodB();
//    }
//}