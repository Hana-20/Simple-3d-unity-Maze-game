using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Xscale;
    private float Zscale;
    float Xmovement;
    float Zmovement;
    Rigidbody rigidBody;
    public int speed = 6;
    private Animator animator;
    private float velocity;

    //Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
        Zscale = transform.localScale.z;
        Xscale = transform.localScale.x;

        // manager = FindObjectOfType<Manager>();

    }
    // Update is called once per frame
    void Update()
    {

        Zmovement = Input.GetAxis("Horizontal");

        if (Zmovement == 0)
        {
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, 0);
        }

        else
        {
            if (Zmovement < 0)
            {
                transform.Rotate(transform.rotation.x, -180f, transform.rotation.z);
                
            }
            if (Zmovement > 0)
            {
                transform.Rotate(transform.rotation.x, 90f, transform.rotation.z);
            }
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, Zscale);
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, Zmovement * speed);
        }
        Xmovement = Input.GetAxis("Vertical");

        if (Xmovement == 0)
        {
            rigidBody.velocity = new Vector3(0, rigidBody.velocity.y, rigidBody.velocity.z);

        }

        else
        {
            transform.localScale = new Vector3(Xscale, transform.localScale.y, transform.localScale.z);
            rigidBody.velocity = new Vector3(-1 * Xmovement * speed, rigidBody.velocity.y, rigidBody.velocity.z);

        }
        if (Zmovement != 0)
        {
            velocity = Zmovement;
        }
        else
        {
            velocity = Xmovement;
        }
        if (velocity < 0)
        {
            velocity *= -1;
        }
        animator.SetFloat("Speed", velocity);

    }
}
