using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsShowUp : MonoBehaviour
{
    public int sceneNumb;

    // Update is called once per frame
    void Start()
    {
        int comp = FindObjectOfType<CurentLevel>().curLevel;
        if(sceneNumb <= comp)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
