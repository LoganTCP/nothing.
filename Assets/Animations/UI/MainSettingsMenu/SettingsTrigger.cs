using UnityEngine;

public class SettingsTrigger : MonoBehaviour
{
    public CanvasGroup settingsCanvasGroup;

    public void TriggerIn()
    {
        settingsCanvasGroup.alpha = 1f;
        settingsCanvasGroup.blocksRaycasts = true;
        settingsCanvasGroup.interactable = true;
    }

    public void TriggerOut()
    {
        settingsCanvasGroup.alpha = 0f;
        settingsCanvasGroup.blocksRaycasts = false;
        settingsCanvasGroup.interactable = false;
    }
}
