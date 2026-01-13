namespace OOP_Project2.Scenes;

public abstract class Scene      // 11. Scene Class 생성
{
    public abstract void Enter();
    public abstract void Update();
    public abstract void Render();
    public abstract void Exit();
}