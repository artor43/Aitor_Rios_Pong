using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class game_manager : MonoBehaviour

{
    public int PuntosP1;
    public int PuntosP2;
    public string puntuacion;
    public TextMeshProUGUI marcadorText;

    private void Start()
    {
       
       
    }
    private void Update()
    {
        
        
        
        puntuacion = PuntosP1 + ":" + PuntosP2;
        marcadorText.text = puntuacion;
        
    }
    
}
