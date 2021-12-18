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
    public Transform direcional;
    public Rigidbody Origen;
    



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
        
        
        Rg.velocity = direção;
        Origen.position = Rg.position;
        

        Origen.position = new Vector3(Origen.position.x - Rg.centerOfMass.x, Origen.position.y - Rg.centerOfMass.y, Origen.position.z - Rg.centerOfMass.z);

        //direcional.position = new Vector3(Origen.position.x + movimento.x, Origen.position.y + 0 ,Origen.position.z + movimento.z);
        if(movimento.x == 1 && movimento.z == 0)
        {
            //Origen.rotation = 90;

        }



        
    }
}
