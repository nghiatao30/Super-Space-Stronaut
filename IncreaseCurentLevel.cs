using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseCurentLevel : MonoBehaviour
{   


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.activeInHierarchy)
        {
            FindObjectOfType<CurentLevel>().curLevel += 1;
        }
    }
}
