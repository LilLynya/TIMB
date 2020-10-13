using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
    SafeUI safeUI;

    private void Start()
    {
        safeUI = FindObjectOfType<SafeUI>();
    }

    public void OnMouseDown()
    {
        Debug.Log("dsjhd");
        safeUI.ShowAnswerPanel();
    }


}
