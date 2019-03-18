using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet : MonoBehaviour 
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;    

    // Start is called before the first frame update
    void Start()
    {
        if (PlatformerCharacter2D.m_FacingRight)
        {
            rb.velocity = transform.right * speed;
        }

        else
        {
            rb.velocity = transform.right * -1 * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }   
}
