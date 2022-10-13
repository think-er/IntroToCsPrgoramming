//using System;
//namespace indexer_exam_2
//{
//    class Grade
//    {
//        public int[] grades = { 24, 75, 90, 74, 51, 74, 83, 52, 31, 58 };
//        public int this[int index] {
//            get {
//                return grades[index];
//            }
//            set {
//                grades[index] = value;
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Grade grades = new Grade();
//            grades[3] = 57;
//            // set
//            grades[8] = 12;
//            // set
//            for (int i = 0; i < 10; i++)
//                Console.WriteLine(grades[i]);
//            // get
//        }
//    }
//}
