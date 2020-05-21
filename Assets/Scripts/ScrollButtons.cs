using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollButtons : MonoBehaviour
{
    public float Speed=1f, CheckPos;
    private RectTransform _recTrans;

    void Start()
    {
        _recTrans = GetComponent<RectTransform>();
    }
    void Update()
    {
        if (_recTrans.offsetMin.y != CheckPos)
        {
            _recTrans.offsetMin += new Vector2(_recTrans.offsetMin.x, Speed);
        }
    }
}
