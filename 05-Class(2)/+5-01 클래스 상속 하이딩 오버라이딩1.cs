//using hiding_console_1;
//using System;

//namespace hiding_console_1
//{
//    class Parent
//    {
//        public int variable = 273;
//        public void Method()
//        {
//            Console.WriteLine("부모의 메소드");
//            Console.WriteLine("variable={0}", variable);
//        }
//    }
//}

//// 상속
//class Child : Parent
//{
//    // 필드 hiding    
//    public new string variable = "hiding";
//    // non-static
//    // <Early binding> new로 재정의된 경우 : 객체 형(형변황 영향)에 따라
//    // 호출되는 Method 정해진다. 
//    // 형변환으로 Parent 객체의 메소드가 호출된다.
//    public new void Method()
//    {
//        Console.WriteLine("자식의 메소드");
//        base.Method();
//        // base 클래스의 필드, 메소드 참조
//        Console.WriteLine("base : variable={0}", base.variable);
//        Console.WriteLine("variable={0}", variable);
//    }
//    static void Main()
//    {
//        Child child = new Child();
//        child.Method();
//        ((Parent)child).Method();
//        // new의 경우, early binding
//        // 부모 클래스로 명시적 형 변환(upcasting)
//    }
//}