using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public GameObject pointFinish;
    public float timeCreate;
    public float speed = 3;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    /*public void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        Destroy(transform.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }*/
}
