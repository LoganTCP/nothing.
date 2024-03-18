using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEscKey : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject FPSController;
    public GameObject MainCamera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            //Set PauseMenu active
            PauseMenu.SetActive(true);
            //Set MainCamera active
            MainCamera.SetActive(true);
            //Set FPSController deactivated
            FPSController.SetActive(false);
            // Set cursor lock mode to None
            Cursor.lockState = CursorLockMode.None;
            // Make the cursor visible
            Cursor.visible = true;
        }
    }
}
