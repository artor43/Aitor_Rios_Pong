using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float movespeed = 10f;//movement speed of paddle
    public float topheight;//upper limit
    public float botheight;//bottom limit
    public bool useArrowkeys = false;

    void Start()
    {

    }

    void Update()
    {
         MovePaddle();
    }
    
    
    
    void MovePaddle()
    {

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, ConstrainPaddle(), this.gameObject.transform.position.z);

    }
    float ConstrainPaddle()
    {
        float nuevaY = this.gameObject.transform.position.y + (PaddleDirection() * movespeed * Time.deltaTime);
        if (nuevaY > topheight)
        {
            nuevaY = topheight;
        }
        if (nuevaY < botheight)
        {
            nuevaY = botheight;
        }
        return nuevaY;
    }
    float PaddleDirection()
    {
        float direccion = 0f;
        if (useArrowkeys == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direccion = 1f;

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                direccion = -1f;

            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                direccion = 1f;

            }
            if (Input.GetKey(KeyCode.S))
            {
                direccion = -1f;

            }
        }
        return direccion;

    }
    

    
        
    
}
