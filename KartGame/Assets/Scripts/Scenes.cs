using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void sceneChange(string targetSceneName)
    {
        //loads target scene defined in editor
        SceneManager.LoadScene(targetSceneName);
    }
}
