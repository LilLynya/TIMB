using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = 9.8f;
    private CharacterController _charController;
    Animator anim;

    private float _rotationX = 0;
    void Start()
    {
        _charController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        if (Input.GetKeyDown(KeyCode.W))
        {
            //Debug.Log("Walk");
            anim.SetBool("walk", true);
            //transform.localEulerAngles = new Vector3(transform.rotation.x, 0, transform.rotation.z);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("walk", false);
        }

        if (Input.GetKeyDown(KeyCode.S)) {

            //Debug.Log("Walk");
            anim.SetBool("walk", true);
            //transform.localEulerAngles = new Vector3(transform.rotation.x, 180, transform.rotation.z);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Debug.Log("Walk");
            anim.SetBool("walk", true);
            _rotationX -= Input.GetAxis("Horizontal");
            //transform.localEulerAngles = new Vector3(transform.rotation.x, -  90, transform.rotation.z);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //Debug.Log("Walk");
            anim.SetBool("walk", true);
            //transform.localEulerAngles = new Vector3(transform.rotation.x, 90, transform.rotation.z);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("walk", false);
        }
    }
}
        
        

