using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    //public variable for controlling mouse sensitivity
    public float mouseSensitivity = 100f;

    //public variable to allow movement and rotation of certain body
    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //locks mouse cursor to centre of screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // variables to gather info on movement of mouse cursor
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //adjusts the rotation up and down based on mouseY
        //xRotation -= mouseY;

        // this prevents camera from rotating too far
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //applies rotation to the local rotation of the camera transform
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // this allows player to look around on X axis
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
