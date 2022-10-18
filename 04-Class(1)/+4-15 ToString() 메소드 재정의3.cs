//using System;
//public class Object2
//{
//    private object value;
//    public Object2(object value)
//    {
//        this.value = value;
//    }
//    public override string ToString()
//    {
//        return base.ToString() + ": " + value.ToString();
//        // 기존 ToString() 기능 
//        // value.ToString() <- ToString() 메소드 재정의
//    }
//}

//public class Example
//{
//    public static void Main()
//    {
//        Object2 obj2 = new Object2('a');
//        Console.WriteLine(obj2.ToString());
//        Console.WriteLine(obj2);
//    }
//}