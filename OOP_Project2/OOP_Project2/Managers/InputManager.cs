namespace OOP_Project2.Managers;

public class InputManager
{
    private static ConsoleKey _current;     // 12. Consolekey 타입의 필드 선언

    private static readonly ConsoleKey[] _keys =    // 69. 입력 키 enum 선언
    {
        ConsoleKey.UpArrow,     // 방향키 위
        ConsoleKey.DownArrow,   // 방향키 아래
        ConsoleKey.LeftArrow,   // 방향키 왼쪽
        ConsoleKey.RightArrow   // 방향키 오른쪽
    };

    public static bool GetKey(ConsoleKey input) // 70. 입력 받은 키 실행
    {
        return _current == input;   
    }

    public static void GetUserInput()           // 71. 플레이어가 입력한 키 확인
    {
        ConsoleKey input = Console.ReadKey(true).Key;   
        _current = ConsoleKey.Clear;

        foreach (ConsoleKey key in _keys)     
        {
            if (key == input)
            {
                _current = input;
                break;
            }
        }
    }


    public static void ResetKey() // 11. 메서드 생성
    {
        _current = ConsoleKey.Clear;   // 13. 현재 Console 값 Clear
    }
}