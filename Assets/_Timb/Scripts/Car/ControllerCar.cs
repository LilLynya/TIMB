using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCar : MonoBehaviour
{
    public GameObject[] CarPrefab;

    public GameObject pointStart;
    public GameObject pointFinish;

    public float timeCreate;

    bool once = false;

    void Update()
    {
        if (!once)
        {
            once = true;
            StartCoroutine(CreateCar());
        }
    }

    IEnumerator CreateCar()
    {
        yield return new WaitForSeconds(timeCreate);
        GameObject car = Instantiate(CarPrefab[Random.Range(0, CarPrefab.Length)]);
        car.transform.position = pointStart.transform.position;
        MoveCar carMove = car.GetComponent<MoveCar>();
        carMove.pointFinish = pointFinish;
        StartCoroutine(CreateCar());
    }
}
