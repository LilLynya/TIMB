using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;

public class ActionDialoge : MonoBehaviour
{
    public void EndDialoge()
    {
        Debug.Log("EndDialoge");
    }

    public void NextFrase()
    {
        VD.Next();
    }
}
