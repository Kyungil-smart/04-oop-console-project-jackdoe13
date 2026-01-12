using OOP_Project2.GameObjects;

namespace OOP_Project2.Utils;

public struct Tile      // 44. 타일 구조체 선언
{
    public GameObject OnTileObject { get; set; } // 45. 타일 위애 무엇이 있는지 확인하는 프로퍼티
    public event Action OnStepPlayer; // 46. 타일 위에 올라서면 발생해야 하는 이벤트
    public Vector Position { get; set; } // 47. 플레이어의 현재 좌표 프로퍼티
    
    public bool HasGameObject => OnTileObject != null; // 48. 람다식 사용하여 타일 위가 Null이 아닌지 확인

    public Tile(Vector position)    // 49. 현재 위치를 받는 함수
    {
        Position = position;        // 50. 현재 위치를 전달받아 프로퍼티에 대입
    }

    public void Print()             // 51. 현재 위치를 갱신하여 출력
    {
        if (HasGameObject)          // 52. HasGameObject 가 있다면
        {
            OnTileObject.Symbol.Print();    // 61. 오브젝트 갱신 후 출력
        }
        else
        {
            ' '.Print();    // 62. 오브젝트 없으면 공백 출력
        }
    }

}