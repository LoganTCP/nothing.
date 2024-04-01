using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Ref Animator comp
    public Animator animator;

    // Ref CanvasGroup comp
    public CanvasGroup canvasGroup;

    // Method to trigger fade in animation
    public void TriggerFadeInAnimation()
    {
        // Enable Animator comp
        animator.enabled = true;
        // Play FadeIn animation
        animator.Play("FadeIn");
    }

    // Method to trigger fade out animation
    public void TriggerFadeOutAnimation()
    {
        // Enable Animator comp
        animator.enabled = true;
        // Play FadeOut animation
        animator.Play("FadeOut");
    }

    // Method to cut out
    public void TriggerOut()
    {
        // Check if an animator exists
        if (animator != null)
        {
            // Disables the animator
            animator.enabled = false;
        }
        // Sets alpha to 0 (invisible)
        canvasGroup.alpha = 0f;
        // Allows mouse click through
        canvasGroup.blocksRaycasts = false;
        // Makes UI non-interactible by keyboard
        canvasGroup.interactable = false;
    }
    
    // Method to cut in
    public void TriggerIn()
    {
        // Check if an animator exists
        if (animator != null)
        {
            // Disables the animator
            animator.enabled = false;
        }
        // Sets alpha to 1 (fully-visible)
        canvasGroup.alpha = 1f;
        // Disallows mouse click through
        canvasGroup.blocksRaycasts = true;
        // Makes UI interactible by keyboard
        canvasGroup.interactable = true;
    }

    // Method to lock the mouse
    public void lockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
