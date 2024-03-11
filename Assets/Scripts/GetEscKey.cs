using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public GameObject PauseMenu;
public class GetEscKey : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("Esc key was pressed");
            PauseMenu.SetActive(true);
        }
    }
}
