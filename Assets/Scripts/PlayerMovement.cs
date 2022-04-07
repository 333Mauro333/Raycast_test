using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.0f;

    CharacterController cc = null;

    Vector3 v3;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
        v3 = Vector3.zero;
    }

    void Update()
    {

    }

    void LateUpdate()
    {
        Movement();


    }


    void Movement()
    {
        float h = Input.GetAxis("HorizontalAxisPlayer");
        float v = Input.GetAxis("VerticalAxisPlayer");
        v3 = transform.localRotation.eulerAngles;

        Vector3 movement = new Vector3();

        movement.x = gameObject.transform.localRotation.eulerAngles.x * h * speed * Time.deltaTime;
        if (v >= 0.0f)
        {
            movement.z = v * speed * Time.deltaTime;
        }
        else
        {
            movement.z = v * (speed / 2.0f) * Time.deltaTime;
        }

        cc.Move(movement);
    }
}
