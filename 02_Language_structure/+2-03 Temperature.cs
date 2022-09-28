using System;
enum Temperature { Low = 2, Medium, High };
// enum의 순서값 변경 2, 3, 4
class Temp {
    public static void Main() {
        Temperature value = Temperature.Medium;
        int val = (int)value;
        // 열거형을 정수형으로 casting(형변환)
        Console.WriteLine("Temperature value is.." + val);
    }
}