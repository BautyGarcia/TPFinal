using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Behaviour : MonoBehaviour
{   
    public float JumpForce;
    Rigidbody rb;
    bool hasJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            transform.Translate(0,0,-0.1f);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(0,0,0.1f);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(0.1f,0,0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(-0.1f,0,0);
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Plataforma"){
            hasJump = true;
        }
    }
}
