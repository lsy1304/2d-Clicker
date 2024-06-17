using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int _defaultCountPerClick = 1;
    public int CurrentCountPerClick;

    private void Start()
    {
        CurrentCountPerClick = _defaultCountPerClick;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        GameManager.Instance.UpdateCount(CurrentCountPerClick);
    }
}
