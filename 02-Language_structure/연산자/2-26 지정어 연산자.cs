//using System;
//using System.Reflection;
//class Apple {
//    // 눈으로 보이진 않지만 상속된 멤버들이 존재한다.
//    public int nSeeds = 0;
//    public void Ripen() { /* ... */ }
//}
//class TypeOfOperatorApp {
//    public static void Main() {
//        Type t = typeof(Apple);
//        string className = t.ToString();
//        MemberInfo[] allMembers = t.GetMembers();
//        // Type.GetMembers() 메소드 
//        // - 주어진 Type의 멤버(properties, methods, fields, events 등)를 반환

//        // MemberInfo 클래스 멤버의 특성에 대한 정보를 얻고, 멤버 메타데이터를
//        // 액세스할 수 있도록 해준다.
//        // System.Reflection 네임스페이스
//        Console.WriteLine("All " + className + " Members:");
//        // foreach문
//        foreach (MemberInfo member in allMembers) {
//            Console.WriteLine(member.ToString());
//        }
//    }
//}