namespace OOP_Project2.Utils;

public struct Vector     // 17. Vector 구조체 선언 (어째서 이건 클래스가 아닌 구조체로 구현하셨을까?)
{
    public int X { get; set; } // 18. int 타입 프로퍼티 X 선언
    public int Y { get; set; } // 19. int 타입 프로퍼티 Y 선언

    public Vector(int x, int y) // 20. 멤버함수 Vector 선언
    {
        X = x;
        Y = y;
    }

    public static Vector Up => new Vector(0, -1);   // 21. 람다식? Vector 구조체 멤버 변수 인스턴스 생성?
    public static Vector Down => new Vector(0, 1);  // 22.                  ""
    public static Vector Left => new Vector(-1, 0); // 23.                  ""
    public static Vector Right => new Vector(1, 0); // 24.                  ""
    
    public static Vector operator +(Vector a,  Vector b) // 25. 람다식 추가 복습 필요.
        => new Vector(a.X + b.X, a.Y + b.Y);
}