//using System;
//// Delegate 정의
//public delegate void MyEventHandler();
//class Button
//{
//    public event MyEventHandler Push;
//    // 이벤트 정의
//    // 클래스 내 필드 형식으로 정의됨.
//    // [event-modifier] + event + DelegateType(정의된 Delegate 형) + EventName(첫 글자 대문자 권장)
    
//    // 이벤트 발생
//    public void OnPush()
//    {
//        // 이벤트 발생 전, 이벤트 핸들러 등록 확인
//        if (Push != null)
//            Push();
//    }
//}


//// 이벤트 처리기 작성
//class EventHandlerClass
//{
//    // 이벤트를 처리하는 메소드 = 델리게이트의 형태 일치
//    public void MyMethodA()
//    {
//        Console.WriteLine("In the EventHandlerClass.MyMethodA ...");
//    }
//    public void MyMethodB()
//    {
//        Console.WriteLine("In the EventHandlerClass.MyMethodB ...");
//    }
//}

//class EventHandlingApp
//{
//    public static void Main()
//    {
//        Button button = new Button();
//        EventHandlerClass obj = new EventHandlerClass();
//        // event에 event처리기 등록
//        button.Push += new MyEventHandler(obj.MyMethodA);
//        button.Push += new MyEventHandler(obj.MyMethodB);
//        button.OnPush(); // Push() 호출: 이벤트 발생
//        button.Push -= new MyEventHandler(obj.MyMethodB);
//        button.OnPush();
//    }
//}