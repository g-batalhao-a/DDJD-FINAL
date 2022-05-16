using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 20;
    public float health = 50f;

    void Start()
    {
    }

    void Update()
    {
        //rb.AddForce(0,0, forwardForce * Time.deltaTime); 
        rb.AddForce(0,0,900 * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(0,0,sidewaysForce * Time.deltaTime);
        }

        if(Input.GetKey("a")){
            rb.AddForce(0,0,-sidewaysForce * Time.deltaTime);
        }

    }

    public void TakeDamage(float amount){
        health -= amount;
        Debug.Log(health);
        if(health <= 0f){
            Destroy(gameObject);
        }
    }

}