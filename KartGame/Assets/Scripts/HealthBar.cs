using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //references the slider in the UI for health
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        //sliders max value defined by the health integer
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        //sets slider value to the health defined
        slider.value = health;
    }
}
