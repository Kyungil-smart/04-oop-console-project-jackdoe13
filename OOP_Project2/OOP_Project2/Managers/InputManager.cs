namespace OOP_Project2.Managers;

public class InputManager
{
    private static ConsoleKey _current;     // 12. Consolekey 타입의 필드 선언
    
    public static void ResetKey() // 11. 메서드 생성
    {
        _current = ConsoleKey.Clear;   // 13. 현재 Console 값 Clear
    }
}