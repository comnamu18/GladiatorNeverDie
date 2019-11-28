using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animat : MonoBehaviour
{
    public Animator g_anim;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            g_anim.SetTrigger("run");
        }
        else
            g_anim.SetTrigger("idel");

    }
}
