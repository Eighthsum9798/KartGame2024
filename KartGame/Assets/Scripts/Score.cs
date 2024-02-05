using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    public static int scoreCount;

    private void Start()
    {
        scoreCount = 1; 
    }

    void Update()
    {
        score.text = "Lap " + Mathf.Round(scoreCount);



        if (scoreCount == 3)
        {
            SceneManager.LoadScene("Win");
        }
            
    }

    

}
