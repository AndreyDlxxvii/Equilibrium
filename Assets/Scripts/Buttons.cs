using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void OnMouseUpAsButton()
    {
        if (gameObject.name == "Restart")
        {
            SceneManager.LoadScene(0);
        }
    }
}
