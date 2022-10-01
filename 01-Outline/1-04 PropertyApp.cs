//using System;
//class PropertyClass {
//    private int privateValue;
//    public int PrivateValue {
//        get { return privateValue; }
//        set { privateValue = value; }
//    }

//    public void PrintValue() {
//        Console.WriteLine("Hidden Value = " + privateValue);
//    }
//}

//class PropertyApp {
//    public static void Main() {
//        int n;
//        PropertyClass obj = new PropertyClass();
//        obj.PrivateValue = 100; // set
//        obj.PrintValue();
//        n = obj.PrivateValue; // get
//        Console.WriteLine("Value = " + n);
//    }
//}