//using System;
//class StringIndexer
//{
//    public char this[string str, int index] {
//        get { return str[index]; } // 문자열내 특정 위치 글자 반환
//    }
//    public string this[string str, int index, int len] {
//        get { return str.Substring(index, len); } // 문자열내 특정 위치에서 임의의 개수 글자 반환
//    }
//}
//class StringIndexerApp
//{
//    public static void Main()
//    {
//        string str = "Hello";
//        StringIndexer s = new StringIndexer();
//        for (int i = 0; i < str.Length; i++)
//            Console.WriteLine("{0}[{1}] = {2}", str, i, s[str, i]); // indexer의 get 동작
//        Console.WriteLine("Substring of {0} is {1}", str, s[str, 2, 3]); // indexer의 get 동작
//        // str의 2번째 인덱스의 문자부터 3개의 길이의 문자열 반환
//    }
//}