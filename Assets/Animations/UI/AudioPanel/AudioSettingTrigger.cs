using UnityEngine;

public class AudioSettingTrigger : MonoBehaviour
{
   public CanvasGroup audioCanvasGroup;

   public void TriggerIn()
   {
    audioCanvasGroup.alpha = 1f;
    audioCanvasGroup.blocksRaycasts = true;
    audioCanvasGroup.interactable = true;
   }

   public void TriggerOut()
   {
    audioCanvasGroup.alpha = 0f;
    audioCanvasGroup.blocksRaycasts = false;
    audioCanvasGroup.interactable = false;
   }
}
