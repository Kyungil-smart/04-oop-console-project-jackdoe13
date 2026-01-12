using OOP_Project2.GameObjects;

namespace OOP_Project2.Utils;

public interface IInteractable      // 78. 플레이어의 현재 위치 값을 가져올 인터페이스 선언
{
    public void Interact(PlayerCharacter player);
}