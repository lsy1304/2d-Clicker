using UnityEngine;

public class UpgradeCountPerClick : UpgradeButton
{
    [SerializeField] private Clicker clicker;

    protected override void Start()
    {
        base.Start();

        button.onClick.AddListener(() => OnClick());
    }

    public void OnClick()
    {
        if (CheckState())
        {
            InfoText.text = $"{++clicker.CurrentCountPerClick} per click";
        }
    }
}
