//using System;
//delegate void DelegateOne();
//delegate void DelegateTwo(int i);
//// 접근지정자(default:internal) + delegate(지정어) + returnType(반환형) + DelegateName(첫 글자 대문자 관례)(parameterList)

class DelegateClass {
    public void MethodA() {
        Console.WriteLine("In the DelegateClass.MethodA ...");
    }
    public void MethodB(int i) {
        Console.WriteLine("DelegateClass.MethodB, i = " + i);
    }

}

class DelegateCallApp {
    public static void Main() {
        DelegateClass obj = new DelegateClass(); // delegate대상이 되는 메소드를 포함하는 객체 생성
        // 델리게이트와 대상 메소드를 연결
        // static 메소드는 instance 메소드와는 다르게 객체 생성 없이 연결 가능

//        DelegateOne d1 = new DelegateOne(obj.MethodA); // delegate 객체(d1) 생성
//        DelegateTwo d2 = new DelegateTwo(obj.MethodB); // delegate 객체(d2) 생성
//        d1(); // invoke MethodA() in DelegateClass // delegate 객체 호출 : 메소드 대리인
//        d2(10); // invoke MethodB(10) in DelegateClass // delegate 객체 호출
//        //DelegateTwo d3 = delegate (int x)
//        //{
//        //    Console.WriteLine(x * 2);
//        //};
//        //d3(10);
//        //// 델리게이트 객체이름(실인자)
//    }
//}