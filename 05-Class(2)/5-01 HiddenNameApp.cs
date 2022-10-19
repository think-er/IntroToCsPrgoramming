// 파생 클래스 개념
// 상속(inheritance)
// 베이스 클래스의 모든 멤버들이 파생 클래스로 전달되는 기능
// 클래스의 재사용성(reusability) 증가
// 상속의 종류
// 단일 상속 (베이스 클래스가 1개) / 다중 상속(베이스 클래스가 2개 이상)
// C#은 단일 상속만 지원

using System;
class BaseClass
{
    // protected 필드
    protected int a = 1;
    protected int b = 2;
}
class DerivedClass : BaseClass
{
    // 필드 이름 동일 (base 클래스와 파생 클래스 필드 이름 동일)
    new int a = 3;
    new double b = 4.5;
    // 파생 클래스의 멤버에 기본 클래스와 동일한 이름을 붙이고자 할 경우 멤버의 정의 앞에 new 를 붙인다.
    // new가 붙은 멤버를 호출하면 항상 파생 클래스쪽의 멤버가 호출된다.(이름 은폐)
    // 이름이 은폐된 기본 클래스의 멤버를 파생 클래스 안에서 사용하려면 base를 이용 (ex: base.a)
    // new 를 생략할 경우 감춤 경고 발생(가능하면 new를 적을 것)
    public void Output()
    {
        Console.WriteLine("BaseClass:a={0}, DerivedClass:a={1}", base.a, a);
        Console.WriteLine("BaseClass:b={0}, DerivedClass:b={1}", base.b, b);
        // 이름 동일 조건에서, 부모 클래스 필드 접근
    }
}
class HiddenNameApp
{
    public static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.Output();
    }
}
