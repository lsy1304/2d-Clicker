using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countUI;
    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
        GameManager.Instance.OnClickEvent += UpdateUI;
    }

    public void UpdateUI()
    {
        _countUI.text = $"Click Count : {GameManager.Instance.CurrentCount}";
    }
}
