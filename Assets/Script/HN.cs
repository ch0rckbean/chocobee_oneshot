using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HN : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.C)){
            anim.Play("clap",-1,0);
        }
         else if(Input.GetKeyDown(KeyCode.X)){
            anim.Play("New State");
        } 
        else if(Input.GetKeyDown(KeyCode.N)){
            anim.Play("nervous");
        }       
    }
}
