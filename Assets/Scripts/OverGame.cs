using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverGame : MonoBehaviour
{
    public GameObject BorderTop;
    public bool temp = false;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
           temp = true;
        }
    }
    void Update()
    {
        temp = BorderTop.GetComponent<BorderTop>().CheckGameOver;
    }
}
