using OOP_Project2.Utils;

namespace OOP_Project2.GameObjects;

public class PlayerCharacter : GameObject       // 27. GameObject를 상속받은 PlayerCharacter Class 선언
{
    public ObservableProperty<int> Health = new ObservableProperty<int>(5);         // 40. HP
    //public ObservableProperty<int> Mana = new ObservableProperty<int>(5);           // 41. MP
    private string _healthGauge;        // 42. HP UI
    //private string _manaGauge;          // 43. MP UI

    public Tile[,] Field { get; set; }  // 63. 맵 배열 프로퍼티 출력?
    public bool IsActiveControl { get; private set; }

    public PlayerCharacter() => Init();

    public void Init()
    {
        Symbol = 'P';
        IsActiveControl = true;
        
    }


}