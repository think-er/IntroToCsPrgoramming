//using System;
//class CLanguage
//{
//    public bool Equal(object obj)
//    {
//        // 파생 클래스는 베이스 클래스로 형 변환 가능
//        // 캐스팅이 가능하면 true 아니면 false 반환
//        return (obj is CLanguage) ? true : false;
//    }
//}

//// CSharp 클래스는 CLanguage 클래스를 상속
//class CSharp : CLanguage
//{
//    new public bool Equal(object obj)
//    {
//        // 베이스 클래스는 파생 클래스로 형 변환 불가능
//        return (obj is CSharp) ? true : false;
//    }
//}

//public class ClassTypeConversionApp
//{
//    public static void Main()
//    {
//        CLanguage c = new CLanguage();
//        CSharp cs = new CSharp();

//        if (c.Equal(cs)) Console.WriteLine("casting up is valid.");
//        // obj 참조 변수는 CSharp 객체를 가리킨다.
//        else Console.WriteLine("casting up is not valid.");
//        if (cs.Equal(c)) Console.WriteLine("casting down is valid.");
//        // obj 참조 변수는 CLanguage 객체를 가리킨다.
//        else Console.WriteLine("casting down is not valid.");
//    }
//}