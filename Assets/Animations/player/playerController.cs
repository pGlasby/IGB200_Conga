﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            anim.SetBool("isWalking",true);

        }else if(Input.GetKey("a")){
            anim.SetBool("isWalking",true);

        }else if(Input.GetKey("s")){
            anim.SetBool("isWalking",true);
        }else if(Input.GetKey("d")){
            anim.SetBool("isWalking",true);
        }else{
            anim.SetBool("isWalking",false);
        }
    }
}
