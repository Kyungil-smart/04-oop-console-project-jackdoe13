namespace OOP_Project2.Utils;

public static class TextExtensions      // 53. 정적 클래스 선언 (내부는 함수오버로딩)
{
    public static void Print(this string text, ConsoleColor color = ConsoleColor.Gray)      // 54. 정적 메서드 함수 선언
    {
        if (color != ConsoleColor.Gray) Console.ForegroundColor = color;                    // 55. 콘솔 색이 회색이 아닌 경우 전경색은 회색
        
        Console.Write(text);    // 56. 글씨 색은 하얀 색
        
        if (color != ConsoleColor.Gray) Console.ResetColor();       // 57. 콘솔 색이 회색이 아닌 경우 콘솔 색깔 리셋
        
    }

    public static void Print(this char character, ConsoleColor color = ConsoleColor.Gray)   // 58. 정적 메서드 함수 오버로딩
    {
        if (color != ConsoleColor.Gray) Console.ForegroundColor = color;
        
        Console.Write(character);
        
        if (color != ConsoleColor.Gray) Console.ResetColor();
        
    }

    public static int GetTextWidth(this string text)        // 59. 복습 필요
    {
        int width = 0;
        foreach (char c in text)
        {
            width += c.GetCharacterWidth();
        }

        return width;
    }

    public static int GetCharacterWidth(this char character)    // 60. 복습 필요
    {
        // 한글 음절(가-힣), CJK 호환문자, 전각 기호/문자 범위는 2칸으로 처리
        if ((character >= '\uAC00' && character <= '\uD7A3') || // 한글 완성형
            (character >= '\u1100' && character <= '\u11FF') || // 한글 자모
            (character >= '\u3130' && character <= '\u318F') || // 한글 호환 자모
            (character >= '\uFF01' && character <= '\uFF60') || // 전각 기호/영숫자
            (character >= '\uFFE0' && character <= '\uFFE6'))   // 전각 특수기호
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }

}