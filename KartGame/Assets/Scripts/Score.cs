using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Text score;

    public static int scoreCount;

    public Timer timer;


    
    

    private void Start()
    {
        scoreCount = 0; 
    }

    void Update()
    {
        score.text = "Lap " + Mathf.Round(scoreCount + 1);



        if (scoreCount >= 3)
        {
            
            
            SceneManager.LoadScene("Win");
        }
            
    }

    

}
