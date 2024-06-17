using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class AutoButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int _defaultCountPerAutoClick = 1;
    [HideInInspector] public int CurrentCountPerAutoClick;

    [SerializeField] private int _defaultAutoClickDelay = 1;
    [HideInInspector] public int CurrentAutoClickDelay;

    private bool _isAuto = false;

    private void Start()
    {
        CurrentCountPerAutoClick = _defaultCountPerAutoClick;
        CurrentAutoClickDelay = _defaultAutoClickDelay;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _isAuto = !_isAuto;
        if (_isAuto) StartCoroutine(nameof(AutoClick));
        else StopCoroutine(nameof(AutoClick));
    }

    IEnumerator AutoClick()
    {
        while (true)
        {
            GameManager.Instance.UpdateCount(CurrentCountPerAutoClick);
            yield return new WaitForSeconds(1f / CurrentAutoClickDelay);
        }
    }
}
