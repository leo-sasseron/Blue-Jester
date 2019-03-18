using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    Animator animator;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        bool r = Input.GetKeyDown(KeyCode.W); 

        animator.SetBool("Roll", r);
    }
}
