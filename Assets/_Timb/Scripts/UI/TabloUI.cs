using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabloUI : MonoBehaviour
{
    public GameObject tablo;

    public string answer;
    void Start()
    {
        tablo.SetActive(false);
    }

    public void ShowTablo()
    {
        tablo.SetActive(true);
    }

    public void CheckAnswer(Text text)
    {
        if(text.text == answer)
        {
            Debug.Log("Good answer");
        }
        else
        {
            Debug.Log("Bad answer");
        }
    }
}
