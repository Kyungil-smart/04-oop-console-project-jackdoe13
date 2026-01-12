namespace OOP_Project2.Utils;

public static class TextExtensions      // 53. 정적 클래스 선언 (내부는 함수오버로딩)
{
    public static void Print(this string text, ConsoleColor color = ConsoleColor.Gray)
    {
        if (color != ConsoleColor.Gray) Console.ForegroundColor = color;
        
        Console.Write(text);
        
    }
}