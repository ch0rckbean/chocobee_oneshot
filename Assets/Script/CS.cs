using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
        anim.Play("New State");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            anim.Play("piano",-1,0);
        }
         else if(Input.GetKeyDown(KeyCode.LeftShift)){
            anim.Play("surprise");
        }     
    }
}
