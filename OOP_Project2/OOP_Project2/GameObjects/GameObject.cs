using OOP_Project2.Utils;
namespace OOP_Project2.GameObjects;

public abstract class GameObject     // 15. PlayerCharacter Class 가 상속받아야 할 GameObject 추상 Class 선언
{
    public char Symbol { get; set; } // 16. char 타입의 프로퍼티 선언
    public Vector Position { get; set; } // 26. Vector 구조체 타입의 프로퍼티 선언
}