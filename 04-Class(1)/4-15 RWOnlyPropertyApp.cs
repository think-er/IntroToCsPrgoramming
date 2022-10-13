//using System;
//class RWOnlyPropertyApp
//{
//    private int readOnlyField = 100;
//    private int writeOnlyField;
//    public int ReadOnlyProperty {
//        get {
//            Console.WriteLine("In the ReadOnlyProperty ...");
//            return readOnlyField;
//        }
//    }
//    public int WriteOnlyProperty {
//        set {
//            Console.WriteLine("In the WriteOnlyProperty ...");
//            writeOnlyField = value;
//        }
//    }
//    public static void Main()
//    {
//        RWOnlyPropertyApp obj = new RWOnlyPropertyApp();
//        obj.WriteOnlyProperty = obj.ReadOnlyProperty;
//        Console.WriteLine("value = " + obj.writeOnlyField);
//    }
//}