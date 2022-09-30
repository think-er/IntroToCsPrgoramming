//using System;
//// 매니지드 코드(managed code): .NET 프레임워크가 관리하는 코드 부분
//// 언매니지드 코드(unmanaged code): C#에서 작성할 수 없는 플랫폼 의존적인 작업의 코드 부분
//// 기존에 개발된 C/C++ 코드를 사용하기 위해서만 사용 (C#에서는 사용하지 말 것)
//class PointerApp {
//    // 포인터 연산은 반드시 unsafe 코드 블록 내에서만 가능
//    unsafe public static void Swap(int *px, int* py) {
//        int tmp = *px;
//        *px = *py;
//        *py = tmp;
//    }

//    public static void Main() {
//        int x = 1, y = 2;
//        Console.WriteLine("Before : x = " + x + ", y = " + y);
//        unsafe {
//            Swap(&x, &y);
//        }
//        Console.WriteLine("After : x = " + x + ", y = " + y);
//    }
//}