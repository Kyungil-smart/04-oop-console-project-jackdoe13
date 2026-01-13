using OOP_Project2.Scenes;      // Class를 참조할 때 반드시 추가 해야하나? 강사님 코드에서 없었는데..
namespace OOP_Project2.Managers;    // 왜 같은 참조인데 위는 using 문이고 아래는 namespace를 사용했을까?

public class SceneManager            // 9. SceneManager Class 생성
{
    public static Action OnChangeScene;     // 10. Action 타입의 필드 선언
    public static Scene Current { get; private set; }   // . Scene 타입의 프로퍼티 선언
    private static Scene _prev;     // . Scene 타입의 변수 선언 (이름에 _는 왜 있는걸까? -> 구조체나 enum 형일 때 붙음)

    private static Dictionary<string, Scene> _scenes = new Dictionary<string, Scene>(); // . Dictionary<string, Scene> 타입의 인스턴스 생성

    public static void AddScene(string key, Scene state)
    {
        if (_scenes.ContainsKey(key)) return;
        
        _scenes.Add(key, state);
    }

    public static void ChangePrevScene()
    {
        Change(_prev);
    }

    public static void Change(string key)
    {
        if (!_scenes.ContainsKey(key)) return;
        
        Change(_scenes[key]);
    }

    public static void Change(Scene scene)
    {
        Scene next = scene;

        if (Current == next) return;
        
        Current?.Exit();
        next.Enter();
        _prev = Current;
        Current = next;
        OnChangeScene?.Invoke();
    }
    
    public static void Update()
    {
        Current?.Update();
    }

    public static void Render()
    {
        Current?.Render();
    }

}