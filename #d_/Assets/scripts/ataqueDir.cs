using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataqueDir : MonoBehaviour
{
   

    public Animator animator;

    public float ataquetempo = 2f;
    private float nextataquetempo = 0f;
    
    void Update()
    {
        if(Time.time >= nextataquetempo)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Ataque();
                nextataquetempo = Time.time + 1f/ ataquetempo;

            }

        }
        
        
    }

    void Ataque()
    {
        animator.SetTrigger("atack");
    }
}
