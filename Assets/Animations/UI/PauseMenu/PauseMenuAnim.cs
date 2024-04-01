using UnityEngine;

public class PauseMenuAnim : MonoBehaviour
{
    // Ref PauseMenu animator comp
    public Animator pauseMenuAnimator;

    public CanvasGroup pauseMenuCanvasGroup;

    // Method to trigger fade in animation
    public void TriggerFadeInAnimation()
    {
        // Enable Pause Menu Animator Comp
        pauseMenuAnimator.enabled = true;
        // Play animation
        pauseMenuAnimator.Play("FadeIn");
    }

    public void TriggerFadeOutAnimation()
    {
        pauseMenuAnimator.enabled = true;
        pauseMenuAnimator.Play("FadeOut");
    }

    public void TriggerOut()
    {
        pauseMenuAnimator.enabled = false;
        pauseMenuCanvasGroup.alpha = 0f;
        pauseMenuCanvasGroup.blocksRaycasts = false;
        pauseMenuCanvasGroup.interactable = false;
    }
    
    public void TriggerIn()
    {
        pauseMenuAnimator.enabled = false;
        pauseMenuCanvasGroup.alpha = 1f;
        pauseMenuCanvasGroup.blocksRaycasts = true;
        pauseMenuCanvasGroup.interactable = true;
    }
}
