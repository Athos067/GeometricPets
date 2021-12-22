using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataqueDir : MonoBehaviour
{
   

    public Animator animator;
    

    public bool atacando;

    public float ataquequant = 2f;
    private float nextataquetempo = 0f;

    public float tempoataque = 60f;
    private float timer = 0f;
    
    
    void Update()
    {
        if(Time.time >= nextataquetempo)
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                Ataque();
                nextataquetempo = Time.time + 1f/ ataquequant;
                atacando = true;

            }

        }
        
        if(tempoataque <= timer)
        {
            atacando = false;
            timer = 0;

            
        }

        if(atacando)
        {
            timer += 1*Time.deltaTime;
        }

        
        
        Debug.Log("proximotempo"+tempoataque*Time.deltaTime);
        Debug.Log("tempo"+timer );
        
        
        
    }

    void Ataque()
    {
        animator.SetTrigger("atack");
    }
}
