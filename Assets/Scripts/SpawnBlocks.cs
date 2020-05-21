using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject[] Prefab;
    void Start()
    {
        InvokeRepeating("RespawnBlock", 0, 5f);
    }

    void RespawnBlock()
    {
        Instantiate(Prefab[Random.Range(0, 4)], new Vector3(Random.Range(-2f, 2f), Random.Range(-10f, -6f), 0), Quaternion.identity);
    }
}
