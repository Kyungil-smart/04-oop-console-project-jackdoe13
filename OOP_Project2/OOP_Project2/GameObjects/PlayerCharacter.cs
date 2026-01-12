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
        }

        if (InputManager.GetKey(ConsoleKey.DownArrow))
        {
            Move(Vector.Down);
        }

        if (InputManager.GetKey(ConsoleKey.LeftArrow))
        {
            Move(Vector.Left);
        }

        if (InputManager.GetKey(ConsoleKey.RightArrow))
        {
            Move(Vector.Right);
        }
    }

    private void Move(Vector direction) // 72. 실제 움직이도록 작업
    {
        if (Field == null || !IsActiveControl) return;      // 73. 움직이는 곳에 아무것도 없으면 바로 리턴

        Vector current = Position;      // 74. 현재 위치
        Vector nextPos = Position + direction; //  75. 현재 위치에서 바라보는 방향 확인 후 다음 이동할 위치에 대입

        GameObject nextTileObjects = Field[nextPos.Y, nextPos.X].OnTileObject; // 76. 다음 위치 좌표 갱신 

        if (nextTileObjects != null)    // 77. 다음 이동할 위치가 null이 아닌 경우 
        {
            if (nextTileObjects is IInteractable) // 79. is as 추가 복습 필요 
            {
                (nextTileObjects as IInteractable).Interact(this);
            }
        }
        
        Field[Position.Y, Position.X].OnTileObject = null;      // 80. 있었던 위치를 Null로
        Field[nextPos.Y, nextPos.X].OnTileObject = this;        // 81. 다음 위치를 현재 위치로   
        Position = nextPos;                                     // 82.         ""

    }

}