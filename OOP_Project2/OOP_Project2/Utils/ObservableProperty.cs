namespace OOP_Project2.Utils;

public class ObservableProperty<T> where T : struct // 28. 템플릿 Class를 선언 where T : struct는 추가 복습 필요
{
    private T _value;   // 29. 템플릿 변수 선언

    public T Value      // 30. 템플릿 프로퍼티 선언?
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged?.Invoke(value);  // 32. ?와 Invoke 추가 복습 필요

        }
        
    }

    public event Action<T> OnValueChanged; // 31. 이벤트 템플릿 Action 선언

    public ObservableProperty(T value = default) // 33. 추가 복습 필요
    {
        _value = value;
    }

    public void AddListener(Action<T> action) // 34.        ""
    {
        OnValueChanged += action;            // 35.         ""
    }

    public void RemoveListener(Action<T> action) // 36.     ""
    {
        OnValueChanged -= action;                // 37.     ""
    }
    
    public void RemoveListenerAll()             // 38.      ""
    {
        OnValueChanged = null;                  // 39.      ""
    }


}