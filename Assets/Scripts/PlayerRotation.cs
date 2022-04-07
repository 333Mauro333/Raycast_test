using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float speed = 0.0f;


    void LateUpdate()
    {
        Rotation();
    }


    void Rotation()
    {
        float hr = Input.GetAxis("HorizontalRotationPlayer");

        transform.Rotate(new Vector3(0.0f, hr * speed * Time.deltaTime, 0.0f));
    }
}
