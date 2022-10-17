//using System;
//delegate void MultiCastDelegate();
//class Schedule
//{
//    public void Now()
//    {
//        Console.WriteLine("Time : " + DateTime.Now.ToString());
//    }

//    public static void Today()
//    {
//        Console.WriteLine("Date: " + DateTime.Today.ToString());
//    }
//}


//class MultiCastApp
//{
//    public static void Main()
//    {
//        Schedule obj = new Schedule();
//        MultiCastDelegate mcd = new MultiCastDelegate(obj.Now);
//        mcd += new MultiCastDelegate(Schedule.Today);
//        // 인스턴스 메소드인 Now()와 정적 메소드인 Today()는 형태가 동일하기 때문에 
//        // 델리게이트 MultiCastDelegate로 캡슐화가 가능하며 각각의 참조 형식은 obj.Now()와 Schedule.Today()가 된다.
//        mcd();
//    }
//}