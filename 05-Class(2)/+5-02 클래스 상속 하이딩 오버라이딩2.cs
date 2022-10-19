//using overriding_console_1;
//using System;

//namespace overriding_console_1
//{
//    class Parent
//    {
//        // public virtual int variable = 273; 
//        // virtual 키워드는 메소드만 가능
//        public int variable = 273;
//        // 가상(virtual) 메소드 (override 예정 지시)
//        // override 메소드
//        // 이를 명확하게 하기 위해 부모 클래스의 메소드에 virtual를,
//        // 자식 클래스의 메소드에는 override를 붙인다. (virtual ~ override 조합 필수)
//        // -> new 와 달리 형 변환을 통해, 부모(base) 클래스의 메소드를 접근 가능
//        public virtual void Method()
//        {
//            Console.WriteLine("부모의 메소드");
//            Console.WriteLine("variable={0}", variable);
//        }
//    }
//}

//// 상속
//class Child : Parent
//{
//    // public override string variable = "overriding"; 
//    // override 키워드는 메소드만 사용 가능

//    public new string variable = "overriding";
//    // non-static
//    // <late binding>: override로 재정의된 경우 
//    // -객체 형(형변환 영향)에 따라 호출되는 
//    // Method 정해지지 않고, 참조 변수(Child)가 가리키는 실제 객체인
//    // Child 객체의 메소드가 호출됨
//    public override void Method()
//    {
//        Console.WriteLine("자식의 메소드");
//        base.Method();
//        Console.WriteLine("base : variable={0}", base.variable);
//        Console.WriteLine("variable={0}", variable);
//    }

//    static void Main(string[] args)
//    {
//        Child child = new Child();
//        // 객체 생성
//        child.Method();
//        ((Parent)child).Method();
//        // Late binding 다형성에 널리 사용
//        // 부모 클래스로 형변환해도, 호출되는 method는 파생클래스의
//        // override된 메소드 호출 (child 객체가 가리키는 메소드 호출)
//        // Parent par = new Child(); <- upcasting
//        // par.Method();
//    }
//}