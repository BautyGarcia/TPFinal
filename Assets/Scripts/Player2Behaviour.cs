using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Behaviour : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Return)){
            if (hasJump){
                rb.AddForce(Vector3.up * JumpForce,ForceMode.Impulse);
                hasJump = false;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0,-movementSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,0,movementSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(movementSpeed,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(-movementSpeed,0,0);
        }

        if (transform.position.y <= -2){
            transform.position = new Vector3(1,1,0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Plataforma" || col.gameObject.name == "PlataformaVolatil")
        {
            hasJump = true;
        }

        if (col.gameObject.name == "ObjectiveCylinder" || col.gameObject.name == "Bala(Clone)")
        {
            transform.position = new Vector3(-1,1,0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}

