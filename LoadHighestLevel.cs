using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadHighestLevel : MonoBehaviour
{

    public void LoadHighestLevelButton()
    {   
        int numbScene = FindObjectOfType<CurentLevel>().curLevel;
        if (numbScene == 1) return;
        SceneManager.LoadScene(numbScene);
    }
}