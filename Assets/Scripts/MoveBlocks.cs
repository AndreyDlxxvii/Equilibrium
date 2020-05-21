using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
{
    private float _speed = 0.02f;
    private Vector3 _vector;

    private void Start()
    {
        _vector = new Vector3(0f, 1f, 0f);
    }
    void FixedUpdate()
    {
        transform.Translate(_vector * _speed);
    }
}
