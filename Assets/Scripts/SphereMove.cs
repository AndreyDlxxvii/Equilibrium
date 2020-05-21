using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SphereMove : MonoBehaviour
{
    public float Speed = 1f;

    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
   
    void FixedUpdate()
    {
        MoveSphere();
    }

    private void MoveSphere()
    {
        float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0, 0);
        _rb.AddForce(movement * Speed);
    }
}
