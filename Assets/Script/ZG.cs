using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZG : MonoBehaviour
{
    public Animator anim;

    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        anim.Play("dancing");

    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space)){
            anim.Play("sing",-1,0);
        }
        else if(Input.GetKeyDown(KeyCode.Tab)){
            anim.Play("dancing",-1,0);
        }
        else if(Input.GetKeyDown(KeyCode.X)){
            anim.Play("breath",-1,0);
        }
    }
     
}
