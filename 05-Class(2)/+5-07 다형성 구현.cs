//using System;
//namespace Polymorphism_1
//{
//    interface IShape
//    {
//        void Draw();
//    }

//    public class Circle : IShape
//    {
//        public void Draw()
//        {
//            Console.WriteLine("I am Circle");
//        }
//        public void CalArea()
//        {
//            // 면적 계산
//        }
//    }

//    public class Rectangle : IShape
//    {
//        public void Draw()
//        {
//            Console.WriteLine("I am Rectangle");
//        }
//        public void CalArea()
//        {
//            // 면적 계산
//        }
//    }

//    public class Line : IShape
//    {
//        public void Draw()
//        {
//            Console.WriteLine("I am Line");
//        }
//        public void CalArea()
//        {
//            // 면적 계산
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // IShape shape = new Circle();
//            Paint(new Circle());
//            // IShape shape = new Rectangle();
//            Paint(new Rectangle());
//            // IShape shape = new Line();
//            Paint(new Line());
//        }
//        static void Paint(IShape shape)
//        {
//            shape.Draw();
//            // 자식이 부모 형변환하는건 가능하다.
//            shape.CalArea();
//        }
//    }//}