//using System;
//class BaseClass
//{
//    // 가상 메소드
//    // virtual 키워드는 파생 클래스에서 재정의해서 사용할 것임을 알려주는 역할
//    // new: s의 객체(참조변수) 형에 따라 메소드 호출
//    // override: s의 객체 참조가 가리키는 객체에 따라 호출(다형성) : 동적 바인딩
//    // (주: override는 부모 클래스의 메소드가 virtual, abstract인 경우 사용 가능)
//    virtual public void MethodA()
//    {
//        Console.WriteLine("Base MethodA");
//    }
//    virtual public void MethodB()
//    {
//        Console.WriteLine("Base MethodB");
//    }
//    virtual public void MethodC()
//    {
//        Console.WriteLine("Base MethodC");
//    }
//}


//class DerivedClass : BaseClass
//{
//    // new 키워드로 재정의
//    new public void MethodA()
//    {
//        Console.WriteLine("Derived MethodA");
//    }
//    // override 키워드로 재정의
//    override public void MethodB()
//    {
//        Console.WriteLine("Derived MethodB");
//    }
//    // 키워드 없이 재정의(new 사용 권장) : 작성자 의도 명확히
//    // <- new, override를 적지 않을 경우, default로 new로 인식함
//    // 경고 발생 : new 사용 권장
//    public void MethodC()
//    {
//        Console.WriteLine("Derived MethodC");
//    }
//    public static void Main()
//    {
//        BaseClass s = new DerivedClass();
//        // Upcasting(상향 캐스팅)
//        s.MethodA();
//        // 정적 바인딩(early binding)
//        s.MethodB();
//        // 동적 바인딩(late binding)
//        s.MethodC();
//        // 정적 바인딩

//        DerivedClass m = new DerivedClass();
//        BaseClass c = (BaseClass)m;
//        c.MethodA();
//        c.MethodB();
//    }
//}