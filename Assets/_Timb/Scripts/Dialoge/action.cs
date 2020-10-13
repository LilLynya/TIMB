using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour
{
    public minUIExample dialogeController;
    FoolPerson person;

    public string nameDialoge = "pasport";

    private void Start()
    {
        person = GetComponent<FoolPerson>();
    }

    private void OnMouseDown()
    {
        //Debug.Log(transform.name);
        person.SetAlive(false);
        dialogeController.ShowDialoge();
        dialogeController.SetTypeDialoge(nameDialoge, person);
        dialogeController.BegeenDialoge();
    }
}
