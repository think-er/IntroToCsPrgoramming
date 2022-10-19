//using System;
//class BaseClass
//{
//    public int a, b;
//    // public 필드: 파생 클래스에서도 접근 가능
//    // protected 로 바꾸면 파생 클래스에서 접근 가능하지만 main에서 불러올 수 없다.
//    public BaseClass()
//    { // 기본 생성자
//        a = 1; b = 1;
//    }
//    public BaseClass(int a, int b)
//    { // 중복 정의된 생성자
//        this.a = a; this.b = b;
//    }
//}

//class DerivedClass : BaseClass
//{
//    public int c;
//    // public DerivedClass() : base() { ... } 컴파일러가 자동으로 추가
//    public DerivedClass()
//    {
//        c = 1;
//    }
//    // 매개 변수를 갖는 base() 생성자 : 명시적으로 호출 필요
//    // -> 생성자 뒤에 ':' 을 적고 호출,
//    // 생략 시 베이스 클래스의 기본 생성자 호출(compiler가 자동으로)
//    public DerivedClass(int a, int b, int c) : base(a, b)
//    {
//        this.c = c;
//    }
//}
//class BaseCallApp
//{
//    public static void Main()
//    {
//        DerivedClass obj1 = new DerivedClass();
//        DerivedClass obj2 = new DerivedClass(1, 2, 3);
//        Console.WriteLine("a={0}, b={1}, c={2}", obj1.a, obj1.b, obj1.c);
//        Console.WriteLine("a={0}, b={1}, c={2}", obj2.a, obj2.b, obj2.c);
//    }
//}