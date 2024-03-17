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
            PauseMenu.SetActive(true);
            MainCamera.SetActive(true);
            FPSController.SetActive(false);
        }
    }
}
