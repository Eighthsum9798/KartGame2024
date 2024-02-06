using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnlockMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //calls unlock mouse function
        unlock();
    }


    void unlock()
    {
        //changes mouse lock state to none
        Cursor.lockState = CursorLockMode.None;
    }
}
