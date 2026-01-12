using OOP_Project2.Managers;
using OOP_Project2.Utils;

namespace OOP_Project2.GameObjects;

public class PlayerCharacter : GameObject       // 27. GameObject를 상속받은 PlayerCharacter Class 선언
{

    public int Hp = 1; // 목숨 하나로 변경
    //public ObservableProperty<int> Health = new ObservableProperty<int>(5);         // 40. HP
    //public ObservableProperty<int> Mana = new ObservableProperty<int>(5);           // 41. MP
    //private string _healthGauge;        // 42. HP UI
    //private string _manaGauge;          // 43. MP UI

    public Tile[,] Field { get; set; }  // 63. 맵 배열 프로퍼티 출력?
    public bool IsActiveControl { get; private set; }   // 64. 실제 움직임 여부 확인

    public PlayerCharacter() => Init(); // 65. 현재 캐릭터 초기화 람다식

    public void Init()
    {
        Symbol = 'P';       //  66. 플레이어는 'P'로 표시
        IsActiveControl = true; // 67. 실제 움직임을 true로 설정
    }
    
    public void Update()    // 68. 콘솔 키 입력에 따른 프로그램 내 반응
    {
        if (InputManager.GetKey(ConsoleKey.UpArrow))
        {
            Move(Vector.Up);
            _inventory.SelectUp();
        }

        if (InputManager.GetKey(ConsoleKey.DownArrow))
        {
            Move(Vector.Down);
            _inventory.SelectDown();
        }

        if (InputManager.GetKey(ConsoleKey.LeftArrow))
        {
            Move(Vector.Left);
        }

        if (InputManager.GetKey(ConsoleKey.RightArrow))
        {
            Move(Vector.Right);
        }

        if (InputManager.GetKey(ConsoleKey.Enter))
        {
            _inventory.Select();
        }
        
    }

}