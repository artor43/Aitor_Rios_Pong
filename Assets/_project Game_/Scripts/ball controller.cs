using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    public float velocidad = 10;
    private Rigidbody2D _rb;
    public game_manager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
        
        _rb.velocity = new Vector3(Random.Range(0, 2), Random.Range(-0.5f, 0.5f)).normalized * velocidad;

        launchball();
    }
     
    // Update is called once per frame
    void FixedUpdate()
    {
        _rb.velocity = _rb.velocity.normalized * velocidad;

    

    }
    void launchball()
    {
        bool isright = false;
        if (Random.value > 0.5f)
        {
            isright = true;
        }


        float xvelocity = -1f;
        if (isright == true)
        {
            xvelocity = 1;
        }
        float yvelocity = Random.Range(-1f, 1f);
        _rb.velocity = new Vector2(xvelocity * velocidad, yvelocity * velocidad);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameManager.PuntosP1++;
        GameManager.PuntosP2++;
        
        

        Debug.Log(GameManager.PuntosP1);
        Debug.Log("ballcontroller hit");
    }
     
       
          

}
