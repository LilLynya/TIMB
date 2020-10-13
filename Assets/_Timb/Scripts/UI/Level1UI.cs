using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1UI : MonoBehaviour
{
    public GameObject Menu;

    bool active = false;

    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActiveMenu();
        }
    }

    public void ActiveMenu()
    {
        active = !active;
        Menu.SetActive(active);
    }
}
