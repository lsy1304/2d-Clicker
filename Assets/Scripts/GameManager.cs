using System;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{   
    public event Action OnClickEvent;

    public int CurrentCount;

    public void CallOnClickEvent()
    {
        OnClickEvent?.Invoke();
    }

    public void UpdateCount(int count)
    {
        CurrentCount += count;
        CallOnClickEvent();
    }
}
