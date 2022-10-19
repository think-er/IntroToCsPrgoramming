//using System;
//class BaseClass
//{
//    public virtual void Output()
//    {
//        Console.WriteLine("In the Base class ...");
//    }
//}

//// 상속
//class DerivedClass : BaseClass
//{
//    // new 가 아닌 override 필요
//    public override void Output()
//    {
//        Console.WriteLine("In the Derived class ...");
//    }
//}

//class PolymorphismApp
//{
//    static void Print(BaseClass obj)
//    {
//        obj.Output();
//    }
//    public static void Main()
//    {
//        BaseClass obj1 = new BaseClass();
//        DerivedClass obj2 = new DerivedClass();
//        Print(obj1);
//        Print(obj2);
//    }
//}