using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public int numberNextLevel;

    public void NextLevel() {
        Application.LoadLevel(numberNextLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
