//using System;
//class MyClass
//{
//    public static void WriteToConsole(string s)
//    {
//        Console.WriteLine(s);
//    }
//    public void Write_2()
//    {
//        Console.WriteLine("non-static method");
//    }

//    public delegate void PrintOut(string s);
//    public delegate void PrintOut_2();

//    public static void Main()
//    {
//        MyClass c = new MyClass();
//        PrintOut print = new PrintOut(WriteToConsole); // delegate 객체 생성
//        PrintOut_2 print_2 = new PrintOut_2(c.Write_2); // delegate 객체 생성
//        print("Hello, Delegate"); // delegate 호출
//        print_2();
//    }
//}