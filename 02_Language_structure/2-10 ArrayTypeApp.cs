//using System;
//class ArrayTypeApp {
//    public static void Main() {
//        int[] ia = new int[3];
//        int[] ib = { 1, 2, 3 };
//        // �迭 ����� �ʱ�ȭ �κ�
//        // int[] ib = new int[] {1, 2, 3} �� ���� �ǹ��̴�.

//        // �̷��Դ� �ȵ�
//        // ---------------------
//        // int[] ib; (x)
//        // ib = { 1, 2, 3 }; (x)
//        // ---------------------
//        int i;
//        for (i = 0; i < ia.Length; i++)
//            // Length ������Ƽ
//            ia[i] = ib[i];
//        for (i = 0; i < ia.Length; i++)
//            Console.Write(ia[i] + " ");
//        Console.WriteLine();
//    }
//}