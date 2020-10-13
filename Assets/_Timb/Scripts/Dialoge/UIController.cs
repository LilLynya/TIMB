using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject TaskPanel;

    void Start()
    {
        StartPanel.SetActive(true);
        TaskPanel.SetActive(true);

    }

    public void StartGame()
    {
        StartPanel.SetActive(false);
    }
    public void ShowTask()
    {
        TaskPanel.SetActive(false);

    }
}
