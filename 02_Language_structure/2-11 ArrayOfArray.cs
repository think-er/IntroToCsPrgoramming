//using System;
//class ArrayOfArray {
//    public static void Main() {
//        int[][] arrayOfArray = new int[3][];
//        int i, j;
//        for (i = 0; i < arrayOfArray.Length; i++)
//            arrayOfArray[i] = new int[i + 3];
//        // 배열 생성
//        // arrayOfArray[0][0~3]
//        // arrayOfArray[1][0~4]
//        // arrayOfArray[2][0~5]

//        for (i = 0; i < arrayOfArray.Length; i++) // 초기화 사용
//            for (j = 0; j < arrayOfArray[i].Length; j++)
//                arrayOfArray[i][j] = i * arrayOfArray[i].Length + j; // i*3+j, i*4+j, i*5+j
//        for (i = 0; i < arrayOfArray.Length; i++) { // 내용 출력
//            for (j = 0; j < arrayOfArray[i].Length; j++)
//                Console.Write(" " + arrayOfArray[i][j]);
//            Console.WriteLine();
//        }
//    }
//}