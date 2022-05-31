﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Behaviour : MonoBehaviour
{   
    public float JumpForce;
    Rigidbody rb;
    bool hasJump = true;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if (hasJump){
                rb.AddForce(Vector3.up * JumpForce,ForceMode.Impulse);
                hasJump = false;
            }
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0,0,-movementSpeed);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(0,0,movementSpeed);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(movementSpeed,0,0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(-movementSpeed,0,0);
        }

        if (transform.position.y <= -2){
            transform.position = new Vector3(1,1,0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Plataforma"){
            hasJump = true;
        }

        if (col.gameObject.name == "ObjectiveCylinder")
        {
            transform.position = new Vector3(1,1,0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
