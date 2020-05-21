using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderTop : MonoBehaviour
{
    public bool CheckGameOver = false;
    private void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "Block")
        {
            Destroy(other.gameObject);
        }
        else if (other.tag == "Player")
        {
            CheckGameOver = true;
        }
    }
}
