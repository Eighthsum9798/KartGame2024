using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laps : MonoBehaviour
{
    private bool isColliding =false;
    public float timeBetweenCollide = 1;
    public float lastCollide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastCollide + timeBetweenCollide)
        {
            Debug.Log("reset");
            isColliding = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (!isColliding && other.CompareTag("Finish"))
        {
            lap();

            isColliding = true;
            
            lastCollide = Time.time;
        }
        
        else if (!isColliding && other.CompareTag("hazard"))
        {
            isColliding = true;
            Debug.Log("hazard");
        }
    }


    void lap()
    {
        
        
            Debug.Log("Lap");

            Score.scoreCount++;
            

        
            
        
        
    }

}
