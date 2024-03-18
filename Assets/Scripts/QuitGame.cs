using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Method to quit the game
    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}