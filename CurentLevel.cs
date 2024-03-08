using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CurentLevel : MonoBehaviour
{

    public static CurentLevel instance;

    public int curLevel;
    public int maxLevel = 6;
    void Start()
    {   
        if (instance != null )
        {
            Destroy(gameObject);
            return;
        }
        instance = this;    
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if(curLevel > maxLevel)
        {
            curLevel = maxLevel;
        }
    }
}
