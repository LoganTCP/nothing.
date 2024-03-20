using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Method to quit the game
    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    // Method to lock the mouse
    public void lockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}