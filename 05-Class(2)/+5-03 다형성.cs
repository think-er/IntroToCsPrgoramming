//using polymorphism_1;
//using System;

//namespace polymorphism_1
//{
//    class Employee
//    {
//        public virtual void Work()
//        {
//            Console.WriteLine("I am an employee");
//        }
//    }

//    class Manager : Employee
//    {
//        public override void Work()
//        {
//            Console.WriteLine("I am a manager.");
//        }
//        // 부모 클래스에 있지 않는 메소드
//        public void Manage()
//        {
//            Console.WriteLine("Managing ...");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee employee = null;
//        employee = new Manager();
//        // upcasting 
//        Console.WriteLine(employee.GetType().ToString());
//        // type이 Employee가 아닌 Manager 형
//        employee.Work();
//        // can't acess Manage()
//        // <late binding 다형성 시 주의사항> 부모 클래스에 있지 않은 method는 접근 불가
//        Manager manager = (Manager)employee;
//        // downcasting
//        manager.Manage();
//        // can acess Manage()
//        // Upcasting 된 참조 변수를 다시 Downcasting 한 후 Manage() 메소드 접근 가능
//        Console.ReadKey();
//    }
//}