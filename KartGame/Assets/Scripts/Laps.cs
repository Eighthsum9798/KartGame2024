using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laps : MonoBehaviour
{
    private bool isColliding =false;
    public float timeBetweenCollide = 1;
    public float lastCollide;
    public int maxHealth = 50;
    public int currentHealth;
    public HealthBar healthBar;

    //stores audio source and clips
    public AudioSource source;
    public AudioClip hazardClip;
    public AudioClip healClip;
    public AudioClip lapClip;

    public string targetSceneName;

    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastCollide + timeBetweenCollide)
        {
            Debug.Log("reset");
            isColliding = false;
        }

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (!isColliding && other.CompareTag("Finish"))
        {
            lap();
            source.PlayOneShot(lapClip);
            isColliding = true;
            
            lastCollide = Time.time;
        }
        
        else if (!isColliding && other.CompareTag("hazard"))
        {
            isColliding = true;
            Debug.Log("hazard");
            source.PlayOneShot(hazardClip);
            Destroy(other.gameObject);
            takeDamage(10);
            lastCollide = Time.time;


        }

        else if (!isColliding && other.CompareTag("health"))
        {
            Debug.Log("heal");
            source.PlayOneShot(healClip);
            Destroy(other.gameObject);
            heal(10);
            lastCollide = Time.time;
        }
    }


    void lap()
    {
        
        
            Debug.Log("Lap");

            Score.scoreCount++;
    
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

    }

    public void heal(int heal)
    {

        if (currentHealth + heal > maxHealth)
        {
            currentHealth = maxHealth;
        }

        else
        {
            currentHealth += heal;
        }
        //currentHealth += heal;
        healthBar.SetHealth(currentHealth);
    }
    
    
        
    


}
