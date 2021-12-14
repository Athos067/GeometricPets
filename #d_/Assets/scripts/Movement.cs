using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpforce = 6f;
    public int extrajumps = 1;
    private int jumps;

    public Rigidbody Rg;
    public Animator Andar;
    public Transform Gfx;
    



    public Vector3 movimento;

    private bool chão;
    public Transform checasolo;
    public LayerMask oqsolo;
    public float checaraio;
    

    // Start is called before the first frame update
    void Start()
    {
        if(Rg == null)
        {
            Rg = GetComponent<Rigidbody>();
        }

        if(Gfx == null)
        {
            Gfx = GetComponent<Transform>();

        }
        jumps = extrajumps;
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.z = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
        //chão = Physics3D.OverlapCircle(checasolo.position, checaraio, oqsolo);

        if(Input.GetButtonDown("Jump"))
        {
            if(chão)
            {
                jumps = extrajumps;

            }


            Rg.AddForce(Rg.velocity.x,5f,Rg.velocity.z);
            chão = false;
            
            

        }

        
        
        
        
        
        
        
        Vector3 direção = new Vector3(movimento.x* moveSpeed * Time.fixedDeltaTime, Rg.velocity.y, movimento.z * moveSpeed * Time.fixedDeltaTime);
        Debug.Log(direção);
        Rg.velocity = direção;

        //movimento.y = 0;
    }
}
