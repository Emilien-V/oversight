using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;
    private float timeToAnimate = 1f;
    private bool active = true;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    void Update()
    {
        timeToAnimate -= Time.deltaTime; // Décrémente timeToDisplay jusqu'a 0;

        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("forward", true);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("forward", false);
                anim.SetBool("run", true);
            }
            else
            {
                anim.SetBool("run", false);
            }
        }
        else
        {
            anim.SetBool("forward", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("down", true);
        }
        else
        {
            anim.SetBool("down", false);
        }

        // TRIGGERS :

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (active == true)
            {
                anim.SetTrigger("jump");
                active = false;
            }

            if (timeToAnimate <= 0) // Si timeToDisplay est inférieur ou égal à 0 alors
            {
                timeToAnimate = 1f;
                active = true;
            }
        }




        // if ()
        // {
        //     anim.SetBool("forward", true);
        // }
        // else
        // {
        //     anim.SetBool("forward", false);
        // }
    }
}
