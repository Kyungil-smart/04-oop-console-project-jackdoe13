using OOP_Project2.GameObjects;
using OOP_Project2.Scenes;

namespace OOP_Project2.Managers;

public class GameManager                // 3. GameManager 클래스 생성
{
    public static bool IsGameOver { get; set; }     // 4. bool 타입 프로퍼티 
    public const string GameName = "순발력 탈출 게임";     // 5. 정적 게임 이름 필드 구현
    private PlayerCharacter _player;

    public void Run()       // 6. 실행 메서드
    {
        Init();             // 7. 실행 시 초기화 메서드 실행

        while (!IsGameOver)
        {
            Console.Clear();
        }

    }

    private void Init()
    {
        IsGameOver = false;     // 8. 처음 시작 시 IsGameOver가 False로 설정
        SceneManager.OnChangeScene += InputManager.ResetKey; // 14. 현재 Scene에 초기화된 Scene 덮어쓰기?
        _player = new PlayerCharacter();
        
        SceneManager.AddScene("Title", new TitleScene());
        SceneManager.Change("Title");
    }

}