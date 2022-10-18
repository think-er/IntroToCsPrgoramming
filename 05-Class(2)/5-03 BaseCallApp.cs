using System;
class BaseClass
{
    public int a, b;
    public BaseClass()
    { // 기본 생성자
        a = 1; b = 1;
    }
    public BaseClass(int a, int b)
    { // 중복 정의된 생성자
        this.a = a; this.b = b;
    }
}

class DerivedClass : BaseClass
{
    public int c;
    public DerivedClass()
    {
        c = 1;
    }
    public DerivedClass(int a, int b, int c) : base(a, b)
    {
        this.c = c;
    }
}