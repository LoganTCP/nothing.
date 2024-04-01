using UnityEngine;

public class MainMenuPlay : MonoBehaviour
{
    // Reference to the Animator component attached to the Canvas GameObject
    public Animator canvasAnimator;

    public CanvasGroup mainCanvasGroup;

    // Method to trigger the fade-out animation
    public void TriggerFadeOutAnimation()
    {
        // Enable Canvas Animator Component
        canvasAnimator.enabled = true;
        // Play the fade-out animation
        canvasAnimator.Play("FadeOut");
    }

    public void TriggerIn()
    {
        canvasAnimator.enabled = false;
        mainCanvasGroup.alpha = 1f;
        mainCanvasGroup.blocksRaycasts = true;
        mainCanvasGroup.interactable = true;
    }

    public void TriggerOut()
    {
        canvasAnimator.enabled = false;
        mainCanvasGroup.alpha = 0f;
        mainCanvasGroup.blocksRaycasts = false;
        mainCanvasGroup.interactable = false;
    }
}
