using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataqueDir : MonoBehaviour
{
    public Transform dir;

    public Movement Movimento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.position = Movimento.movimento;
        
    }
}
