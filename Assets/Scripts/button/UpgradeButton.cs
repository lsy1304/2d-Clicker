using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] protected Button button;
    [SerializeField] protected int cost;
    [SerializeField] protected TextMeshProUGUI LevelText;
    [SerializeField] protected TextMeshProUGUI InfoText;

    protected int curLv;


    protected virtual void Start()
    {
        LevelText = transform.Find("Level").GetComponent<TextMeshProUGUI>();
        InfoText = transform.Find("Info").GetComponent<TextMeshProUGUI>();
        button = GetComponent<Button>();
        GameManager.Instance.OnClickEvent += ToggleSwitch;
        ToggleSwitch();
    }

    protected bool CheckState()
    {
        if (GameManager.Instance.CurrentCount >= cost)
        {
            GameManager.Instance.UpdateCount(-cost);
            curLv++;
            LevelText.text = $"Lv : {curLv}";
            cost *= 2;
            return true;
        }
        else return false;
    }

    private void ToggleSwitch()
    {
        button.interactable = GameManager.Instance.CurrentCount >= cost;
    }
}
