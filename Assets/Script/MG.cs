using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Y)){
            anim.Play("yell",-1,0);
        }
         else if(Input.GetKeyDown(KeyCode.LeftControl)){
            anim.Play("silly");
        }        
    }
}
