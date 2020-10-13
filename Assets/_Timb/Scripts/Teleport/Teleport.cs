using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public int numberLevel;

    public void OnTriggerEnter(Collider col)
    {
        FPSInput player = col.gameObject.GetComponent<FPSInput>();
        if(player != null)
            Application.LoadLevel(numberLevel);
    }

    /*public GameObject Pizzapoint;
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name);
        //col.transform.SetParent(Pizzapoint.transform);
        col.transform.position = Pizzapoint.transform.position;
        col.transform.position = new Vector3(0, 0, 0);
    }*/
}