using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF : MonoBehaviour
{
    public GameObject knight2;

    void Update()
    {
        if (Knight.knight1)
        {
            knight2.SetActive(true);
        }
    }
}
