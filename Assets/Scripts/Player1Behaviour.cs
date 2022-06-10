using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Behaviour : MonoBehaviour
{   
    public float JumpForce;
    Rigidbody rb;
    bool hasJump = true;
    public float movementSpeed;
    int CantRondas = 0;
    public Text OutPutText;
    int RondasGanadas = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementSpeed = 0.1f;
        StartCoroutine(CantRondasTimer());
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
        if (RondasGanadas == CantRondas){
            OutPutText.text = "¡Player 1 Gana!";
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Plataforma" || col.gameObject.name == "PlataformaVolatil")
        {
            hasJump = true;
        }

        if (col.gameObject.name == "ObjectiveCylinder" || col.gameObject.name == "Bala(Clone)")
        {
            transform.position = new Vector3(1,1,0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (col.gameObject.name == "Meta"){
            RondasGanadas++;
            transform.position = new Vector3(1,1,0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    IEnumerator CantRondasTimer()
    {
        yield return new WaitForSeconds(30);
        RondasGanadas = 0;
        CantRondas = ButtonBehave.CantRondas;
    }
}
