using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeUI : MonoBehaviour
{
    public GameObject AnswerPanel;
    public string answer;
    public GameObject FinishViewWin;
    public GameObject FinishViewLose;

    void Start()
    {
        AnswerPanel.SetActive(false);
        FinishViewWin.SetActive(false);
        FinishViewLose.SetActive(false);
    }

    public void ShowAnswerPanel()
    {
        Debug.Log("Active Safe");
        AnswerPanel.SetActive(true);
    }

    public void CheckAnswer(Text text)
    {
        if (text.text == answer)
        {
            Debug.Log("Good answer");
            FinishViewWin.SetActive(true);
        }
        else
        {
            Debug.Log("Bad answer");
            FinishViewLose.SetActive(true);
        }
    }
}
