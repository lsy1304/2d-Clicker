using UnityEngine;

public class UpgradeAutoClickDelay : UpgradeButton
{
    [SerializeField] AutoButton autoButton;

    protected override void Start()
    {
        base.Start();

        button.onClick.AddListener(() => OnClick());
    }

    public void OnClick()
    {
        if (CheckState())
        {
            InfoText.text = $"{++autoButton.CurrentAutoClickDelay} per sec";
        }
    }
}
